using System;

namespace FiledSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass("name");
        }
    }

    internal class MyClass
    {
        private readonly string _name;

        public MyClass(string name)
        {
            _name = name;
        }
    }
}