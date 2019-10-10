using System;

namespace CSharper_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = new Calculation().Add(1, 2);
        }
    }

    public class Calculation
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}