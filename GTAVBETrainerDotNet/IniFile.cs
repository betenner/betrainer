// Copyright (c) BE Group 2015-2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace BEGroup.Utility
{
    /// <summary>
    /// Represents a Windows standard INI file
    /// </summary>
    public class IniFile
    {
        // Regex to detect section
        private static readonly Regex Regex_Section = new Regex(@"^\[([^\]]+)\]$", RegexOptions.Compiled);

        // Regex to detect key/value
        private static readonly Regex Regex_KeyValue = new Regex(@"^([^\=]+)\=(.+)$", RegexOptions.Compiled);

        // Comment markers
        private static readonly string[] COMMENT_MARKERS = { ";", "//" };

        // Section format
        private const string FORMAT_SECTION = "[{0}]";

        // Key/value pair format
        private const string FORMAT_KEY_VALUE = "{0}={1}";

        // INI file content
        private Dictionary<string, Dictionary<string, string>> _content = null;

        // INI file path
        private string _path = null;

        /// <summary>
        /// Opens the specified INI file, if the file does not exist, create one.
        /// </summary>
        /// <param name="path">Path of the file</param>
        /// <returns>INI file object</returns>
        public IniFile(string path)
        {
            _content = new Dictionary<string, Dictionary<string, string>>();
            _path = path;

            // Create
            if (!File.Exists(path))
            {
                File.CreateText(path).Close();
                return;
            }

            // Open
            bool sectionFound = false;
            Dictionary<string, string> currentSection = null;
            string data = null;
            using (StreamReader sr = new StreamReader(path))
            {
                data = sr.ReadToEnd();
            }
            if (string.IsNullOrEmpty(data)) return;
            string[] lines = data.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (lines == null || lines.Length == 0) return;

            foreach (string l in lines)
            {
                string line = l.Trim();

                // Ignore empty line
                if (line == string.Empty) continue;

                // Ignore remark line
                bool isRemarkLine = false;
                foreach (string remarkMarker in COMMENT_MARKERS)
                {
                    if (line.StartsWith(remarkMarker))
                    {
                        isRemarkLine = true;
                        break;
                    }
                }
                if (isRemarkLine) continue;

                // Try matching section or key/value pair
                Match matchSection = Regex_Section.Match(line);
                Match matchKeyValue = Regex_KeyValue.Match(line);
                if (!sectionFound && matchKeyValue.Success)
                {
                    throw new InvalidDataException("A key/value pair must occur after a section marker.");
                }
                if (matchSection.Success)
                {
                    sectionFound = true;
                    string section = matchSection.Groups[1].Value;
                    if (_content.ContainsKey(section))
                    {
                        currentSection = _content[section];
                    }
                    else
                    {
                        currentSection = new Dictionary<string, string>();
                        _content.Add(section, currentSection);
                    }
                }
                else if (matchKeyValue.Success)
                {
                    string key = matchKeyValue.Groups[1].Value;
                    string value = matchKeyValue.Groups[2].Value;
                    if (currentSection.ContainsKey(key))
                    {
                        currentSection[key] = value;
                    }
                    else
                    {
                        currentSection.Add(key, value);
                    }
                }
            }
        }
    
        /// <summary>
        /// Determines whether this INI file contains the specified section.
        /// </summary>
        /// <param name="section">Section name</param>
        /// <returns>true if this INI file does contain the specified section; otherwise false.</returns>
        public bool ContainsSection(string section)
        {
            if (section == null) throw new ArgumentNullException("section");
            return _content.ContainsKey(section);
        }

        /// <summary>
        /// Determines whether this INI file contains the specified key in the specified section.
        /// </summary>
        /// <param name="section">Section name</param>
        /// <param name="key">Key name</param>
        /// <returns>true if this INI file does contain the specified key in the specified section; otherwise false.</returns>
        public bool ContainsKey(string section, string key)
        {
            if (!ContainsSection(section)) return false;
            return _content[section].ContainsKey(key);
        }

        /// <summary>
        /// Gets the value with the specified section and the specified key.
        /// </summary>
        /// <param name="section">Section name</param>
        /// <param name="key">Key name</param>
        /// <returns>The value if found; otherwise null.</returns>
        public string GetValue(string section, string key)
        {
            if (!ContainsKey(section, key)) return null;
            return _content[section][key];
        }

        /// <summary>
        /// Creates an empty section to this INI file, if the section already exists, nothing will be done.
        /// </summary>
        /// <param name="section">Section name</param>
        public void CreateSection(string section)
        {
            if (ContainsSection(section)) return;
            _content.Add(section, new Dictionary<string, string>());
        }

        /// <summary>
        /// Creates an empty key to this INI file, if the key already exists, nothing will be done.
        /// If the section does not exist, it will be created.
        /// </summary>
        /// <param name="section">Section name</param>
        /// <param name="key">Key name</param>
        public void CreateKey(string section, string key)
        {
            if (!ContainsSection(section)) CreateSection(section);
            if (ContainsKey(section, key)) return;
            _content[section].Add(key, null);
        }

        /// <summary>
        /// Sets the value of the specified key in the specified section.
        /// If the section and/or key does not exist, they will be created.
        /// </summary>
        /// <param name="section">Section name</param>
        /// <param name="key">Key name</param>
        /// <param name="value">Value</param>
        public void SetValue(string section, string key, string value)
        {
            if (!ContainsKey(section, key)) CreateKey(section, key);
            _content[section][key] = value;
        }

        /// <summary>
        /// Clears the entire INI file.
        /// </summary>
        public void Clear()
        {
            _content.Clear();
        }

        /// <summary>
        /// Removes the specified key in the specified section, if the key and/or section does not exist, nothing will be done.
        /// </summary>
        /// <param name="section">Section name</param>
        /// <param name="key">Key name</param>
        public void RemoveKey(string section, string key)
        {
            if (!ContainsKey(section, key)) return;
            _content[section].Remove(key);
        }

        /// <summary>
        /// Removes all sections that with the name starts with the specified string.
        /// </summary>
        /// <param name="startsWith">Starts with string</param>
        /// <param name="ignoreCase">true to ignore case; otherwise false</param>
        public void RemoveSectionsStartsWith(string startsWith, bool ignoreCase = true)
        {
            List<string> removes = new List<string>(_content.Count);
            foreach (string key in _content.Keys)
            {
                if ((ignoreCase ? key.ToLower() : key).StartsWith((ignoreCase ? startsWith.ToLower() : startsWith)))
                {
                    removes.Add(key);
                }
            }
            foreach (string key in removes)
            {
                _content.Remove(key);
            }
        }

        /// <summary>
        /// Removes all key/value pairs that with the key starts with the specified string in the specified section.
        /// </summary>
        /// <param name="section">Section name</param>
        /// <param name="startsWith">Starts with string</param>
        /// <param name="ignoreCase">true to ignore case; otherwise false</param>
        public void RemoveKeysStartsWith(string section, string startsWith, bool ignoreCase = true)
        {
            if (!ContainsSection(section)) return;
            List<string> removes = new List<string>(_content.Count);
            foreach (string key in _content[section].Keys)
            {
                if ((ignoreCase ? key.ToLower() : key).StartsWith((ignoreCase ? startsWith.ToLower() : startsWith)))
                {
                    removes.Add(key);
                }
            }
            foreach (string key in removes)
            {
                _content[section].Remove(key);
            }
        }

        /// <summary>
        /// Removes the specified section and all its key/value pairs, if the section does not exist, nothing will be done.
        /// </summary>
        /// <param name="section">Section name</param>
        public void RemoveSection(string section)
        {
            if (!ContainsSection(section)) return;
            _content.Remove(section);
        }

        /// <summary>
        /// Saves this INI file to the specified path.
        /// </summary>
        /// <param name="path">Path of the INI file</param>
        /// <param name="overwrite">whether to overwrite if the target file exists</param>
        public void SaveAs(string path, bool overwrite = true)
        {
            if (File.Exists(path))
            {
                if (overwrite) File.Delete(path); else throw new IOException("Target file exists and cannot be overwritten.");
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string section in _content.Keys)
                {
                    sw.WriteLine(FORMAT_SECTION, section);
                    foreach (string key in _content[section].Keys)
                    {
                        sw.WriteLine(FORMAT_KEY_VALUE, key, _content[section][key]);
                    }
                    sw.WriteLine();
                }
                sw.Flush();
            }
        }

        /// <summary>
        /// Saves the current INI file.
        /// </summary>
        public void Save()
        {
            SaveAs(_path);
        }
    }
}
