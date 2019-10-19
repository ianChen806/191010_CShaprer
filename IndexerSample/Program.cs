using System;

namespace IndexerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection();
            stringCollection[0] = "Hello, World";
            
            Console.WriteLine(stringCollection[0]);
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