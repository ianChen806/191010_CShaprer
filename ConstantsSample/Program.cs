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
        private string _name = "TestFiled";

        private string Test()
        {
            var testConst = Name + " const";
            
            var testFiled = _name + " filed";

            return testConst + testFiled;
        }
    }
}