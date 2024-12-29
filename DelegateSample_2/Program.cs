using System;

namespace DelegateSample_2
{
    public delegate string ShowNameFunction(string name);

    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();
            var name = myClass.ShowName(value => $"my name: {value}");

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
