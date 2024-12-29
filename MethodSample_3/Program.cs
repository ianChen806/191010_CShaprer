using System;

namespace MethodSample_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result1 = new Calculation()
                .Add(1);
            var result = new Calculation()
                .Add(1m, 2d);
            var result2 = new Calculation()
                .Add(1, 2, 3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    internal class Calculation
    {
        public int Add(int first, int second = 0)
        {
            return first + second;
        }

        public int Add(int first)
        {
            return Add(first, 0);
        }

        public int Add(object first, object second)
        {
            return 123;
        }

        public int Add(int first, int second, int third)
        {
            return first + second + third;
        }
    }
}
