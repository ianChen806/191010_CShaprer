using System;

namespace PropertySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.FirstName = "123";
            myClass.LastName = "354";

            Console.WriteLine(myClass.Id);
            Console.WriteLine(myClass.FirstName);
        }
    }

    internal class MyClass
    {
        public int Id { get; private set; }

        public string LastName { private get; set; }

        public string FirstName { get; set; }
    }

    public class MyClass2
    {
        // public string Name { get; set; }

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