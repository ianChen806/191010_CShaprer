using System;

namespace PrimitiveTypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "123";

            System.String a2 = "123";

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a1 == a2);
        }
    }
}