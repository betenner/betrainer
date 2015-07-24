using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAVBETrainerDotNet
{
    /// <summary>
    /// Multi-string class.<br />
    /// A string class that contains a default string and multiple sub strings.
    /// </summary>
    public class MString
    {
        // Implicit conversion
        public static implicit operator String(MString a)
        {
            return a._default;
        }

        // Implicit conversion
        public static implicit operator MString(String a)
        {
            return new MString(a);
        }

        /// <summary>
        /// Gets or sets the specified sub string
        /// </summary>
        /// <param name="code">Code of sub string</param>
        /// <returns></returns>
        public string this[int code]
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
        private Dictionary<int, string> _dict = new Dictionary<int, string>();

        // Default string
        private string _default = null;

        /// <summary>
        /// Creates an instance of MLString that only contains a default empty string.
        /// </summary>
        public MString()
        {
            _default = string.Empty;
        }

        /// <summary>
        /// Creates an instance of MLString that only contains a default string.
        /// </summary>
        /// <param name="defaultString">Default string</param>
        public MString(string defaultString)
        {
            _default = defaultString;
        }

        /// <summary>
        /// Creates an instance of MLString that contains a default string and multiple sub strings.
        /// </summary>
        /// <param name="defaultString">Default string.</param>
        /// <param name="strings">Sub string params</param>
        public MString(string defaultString, params KeyValuePair<int, string>[] strings)
        {
            _default = defaultString;
            foreach (KeyValuePair<int, string> kvp in strings)
            {
                _dict.Add(kvp.Key, kvp.Value);
            }
        }

        public override string ToString()
        {
            return _default;
        }
    }
}
