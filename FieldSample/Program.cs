using System;

namespace FieldSample
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

    public class MyClass
    {
        private string _name = "field";

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