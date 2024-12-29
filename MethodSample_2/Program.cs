using System;

namespace CSharper_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var value1 = 1;
            var value2 = 2;
            var result = new Calculation().Add(value1, value2);

            Console.WriteLine(result);
        }
    }

    internal class Calculation
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Add2(int first, int second)
        {
            return first + second;
        }
    }
}
