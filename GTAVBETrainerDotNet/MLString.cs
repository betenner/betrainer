using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Multi-language string class.<br />
    /// A string class that supports multi-language.
    /// </summary>
    public class MLString : IComparable<MLString>
    {
        // Implicit conversion
        public static implicit operator String(MLString a)
        {
            return a._default;
        }

        // Implicit conversion
        public static implicit operator MLString(String a)
        {
            return new MLString(a);
        }

        /// <summary>
        /// Gets or sets the text of specified language
        /// </summary>
        /// <param name="code">Language code</param>
        /// <returns></returns>
        public string this[string code]
        {
            get
            {
                if (_dict.ContainsKey(code)) return _dict[code];
                return _default;
            }
            set 
            { 
                if (_dict.ContainsKey(code))
                {
                    _dict[code] = value;
                }
                else
                {
                    _dict.Add(code, value);
                }
            }
        }

        // Inner dictionary
        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        // Default string
        private string _default = null;

        /// <summary>
        /// Creates an instance that only contains a default empty string.
        /// </summary>
        public MLString()
        {
            _default = string.Empty;
        }

        /// <summary>
        /// Creates an instance that only contains a default string.
        /// </summary>
        /// <param name="defaultString">Default string</param>
        public MLString(string defaultString)
        {
            _default = defaultString;
        }

        /// <summary>
        /// Creates an instance that contains a default string and multiple language sub strings.
        /// </summary>
        /// <param name="defaultString">Default string.</param>
        /// <param name="strings">Sub string params</param>
        public MLString(string defaultString, params KeyValuePair<string, string>[] strings)
        {
            _default = defaultString;
            foreach (KeyValuePair<string, string> kvp in strings)
            {
                _dict.Add(kvp.Key, kvp.Value);
            }
        }

        public override string ToString()
        {
            return _default;
        }

        public string Replace(string old, string newOne)
        {
            return Utils.ML(this).Replace(old, newOne);
        }

        public int CompareTo(MLString other)
        {
            return Utils.ML(this).CompareTo(Utils.ML(other));
        }
    }
}
