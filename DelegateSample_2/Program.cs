using System;

namespace DelegateSample_2
{
    public delegate string ShowNameFunction(string name);

    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var name = myClass.ShowName(value => $"my name: {value}");

            Console.WriteLine(name);
        }
    }

    internal class MyClass
    {
        private string _name = "Test";

        public string ShowName(ShowNameFunction function)
        {
            return function.Invoke(_name);
        }
    }
}