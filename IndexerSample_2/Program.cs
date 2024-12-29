using System;
using System.Collections.Generic;

namespace IndexerSample_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass["Name"] = "Test";
            myClass["IP"] = "127.0.0.1";
        }
    }

    internal class MyClass
    {
        private readonly static Dictionary<string, string> _values = new Dictionary<string, string>();

        public string this[string ip]
        {
            get => _values[ip];
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
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
