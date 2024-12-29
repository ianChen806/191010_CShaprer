using System;

namespace ConstantsSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MyClass.Name);
        }
    }

    internal class MyClass
    {
        public const string Name = "TestConst";
    }
}
