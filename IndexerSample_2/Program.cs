using System.Collections.Generic;

namespace IndexerSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass["Name"] = "Test";
            myClass["IP"] = "127.0.0.1";
        }
    }

    internal class MyClass
    {
        private Dictionary<string, string> _values = new Dictionary<string, string>();
        
        public string this[string ip]
        {
            get { return _values[ip]; }
            set
            {
                if (_values.ContainsKey(ip) == false)
                {
                    _values.Add(ip, value);
                }
                else
                {
                    _values[ip] = value;
                }
            }
        }
    }
}