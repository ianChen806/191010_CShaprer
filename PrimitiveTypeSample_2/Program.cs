using System;

namespace PrimitiveTypeSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "a";

            System.String a2 = "a";

            string a3 = new string("a");

            System.String a4 = new System.String("a");

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
        }
    }
}