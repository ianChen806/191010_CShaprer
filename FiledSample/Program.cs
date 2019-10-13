using System;

namespace FiledSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            // var myClass = new MyClass("name");
            // var myClass = new MyClass("name",123);

            var name = myClass.GetName();

            Console.WriteLine(name);
        }
    }

    internal class MyClass
    {
        private readonly string _name = "123";

        public MyClass()
        {
            _name = "3455";
        }

        public MyClass(string name)
        {
        }

        public MyClass(string name, int index)
        {
        }

        public string GetName()
        {
            return _name;
        }
    }
}