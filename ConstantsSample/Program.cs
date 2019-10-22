using System;

namespace ConstantsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass.Name);
        }
    }

    internal class MyClass
    {
        public const string Name = "TestConst";
    }
}