using System;

namespace IndexerSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stringCollection = new SampleCollection();
            stringCollection[0] = "Hello, World";

            var value = stringCollection[0];
            Console.WriteLine(value);
        }
    }

    internal class SampleCollection
    {
        private readonly string[] values = new string[100];

        public string this[int i]
        {
            get => values[i];
            set => values[i] = value;
        }
    }
}
