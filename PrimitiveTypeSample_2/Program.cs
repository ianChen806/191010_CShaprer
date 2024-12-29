using System;

namespace PrimitiveTypeSample_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a1 = "a";

            var a2 = "a";
            var s = a1 + a2;

            var a3 = new string("a");

            var a4 = new string("a");

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            new MyClass();
        }
    }

    internal class MyClass
    {
    }
}
