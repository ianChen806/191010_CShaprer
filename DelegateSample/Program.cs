using System;

namespace DelegateSample
{
    public delegate string ShowNameFunction(string name);

    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var name = myClass.ShowName(Add);

            Console.WriteLine(name);
        }

        private static string Add(string value)
        {
            return $"my name: {value}";
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