using System;

namespace PropertySample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            Console.WriteLine(myClass.GetName());
        }
    }

    internal class MyClass
    {
        private string _name;

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}