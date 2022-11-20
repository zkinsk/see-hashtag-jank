using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }
    }
}