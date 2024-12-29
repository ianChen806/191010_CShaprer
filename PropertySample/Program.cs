using System;

namespace PropertySample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Name = "354";

            Console.WriteLine(myClass.Name);
        }
    }

    internal class MyClass
    {
        public string Name { get; set; } = "123";
    }
}
