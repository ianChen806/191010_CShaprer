using System;

namespace PrimitiveTypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1;

            System.Int32 a2 = 1;

            int a3 = new int();

            System.Int32 a4 = new System.Int32();

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
        }
    }
}