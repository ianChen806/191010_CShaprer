using System;

namespace FieldSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();

            // var myClass = new MyClass("name");
            // var myClass = new MyClass("name",123);

            var name = myClass.GetName();

            Console.WriteLine(name);
        }
    }

    public class MyClass
    {
        private readonly string _name = "field";

        public MyClass()
            : this("this")
        {
            _name = "Ctor";
        }

        public MyClass(string name)
        {
            _name = "ctor name";
        }

        public MyClass(string name, int index)
        {
            _name = "ctor name index";
        }

        public string GetName()
        {
            return _name;
        }
    }
}
