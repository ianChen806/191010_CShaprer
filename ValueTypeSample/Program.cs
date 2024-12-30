using System;

namespace ValueTypeSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int value = 123;

            ChangeValue(value);

            Console.WriteLine(value);
        }

        private static void ChangeValue(int input)
        {
            input = 0000;
        }
    }
}
