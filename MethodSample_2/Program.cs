using System;

namespace CSharper_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 1;
            int value2 = 2;
            int result = new Calculation().Add(value1, value2);

            Console.WriteLine(result);
        }
    }

    internal class Calculation
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Add2(int first, int second) => first + second;
    }
}