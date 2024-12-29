using System;
using System.Text;

namespace StringSample_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Test");
            stringBuilder.Append("123");
            stringBuilder.Append("456");
            var value = stringBuilder.ToString();

            Console.WriteLine(value);
        }
    }
}
