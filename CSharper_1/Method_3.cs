using System;

namespace CSharper_1
{
    class Program3
    {
        static void Main3(string[] args)
        {
            int value1 = 1;
            int value2 = 2;
            int result = new Calculation3().Add(value1, value2);

            Console.WriteLine(result);
        }
    }

    public class Calculation3
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}