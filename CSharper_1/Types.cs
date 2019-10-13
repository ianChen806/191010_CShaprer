using System;

namespace CSharper_1
{
    public class PrimitiveType
    {
        void Main()
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

    internal class MyClass
    {
        public string Name { get; set; }
    }

    internal struct MyStruct
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}