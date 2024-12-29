using System;

namespace DelegateSample
{
    public delegate string ShowNameFunction(string name);

    internal class Program
    {
        private static string Add(string value)
        {
            return $"my name: {value}";
        }

        private static void Main(string[] args)
        {
            var myClass = new MyClass();
            var name = myClass.ShowName(Add);

            Console.WriteLine(name);
        }
    }

    internal class MyClass
    {
        private readonly string _name = "Test";

        public string ShowName(ShowNameFunction function)
        {
            return function.Invoke(_name);
        }
    }
}
