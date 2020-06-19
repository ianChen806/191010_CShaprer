using System;
using System.Collections.Generic;

namespace IndexerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection();
            stringCollection[0] = "Hello, World";

            var value = stringCollection[0];
            Console.WriteLine(value);
        }
    }

    internal class SampleCollection
    {
        private string[] values = new string[100];

        public string this[int i]
        {
            get
            {
                return values[i];
            }
            set
            {
                values[i] = value;
            }
        }
    }
}