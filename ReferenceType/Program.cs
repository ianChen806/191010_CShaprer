using System;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Name = "Source";

            SetName(myClass);

            Console.WriteLine(myClass.Name);
        }

        private static void SetName(MyClass myClass)
        {
            myClass.Name = "Change";
        }
    }

    internal class MyClass
    {
        public string Name { get; set; }
    }
}