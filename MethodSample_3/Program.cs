using System;

namespace MethodSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = new Calculation().Add(1, 2);
            var result2 = new Calculation().Add(1, 2, 3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    internal class Calculation
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Add(int first, int second, int third)
        {
            return first + second + third;
        }
    }
}