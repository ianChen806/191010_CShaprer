using System;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Threading.Channels;

namespace PropertySample_2
{
    class Program
    {
        private void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Name = "354";

            // myClass.Name2 = "354";

            Console.WriteLine(myClass.Name);

            Console.WriteLine(myClass.Name2);

            // Console.WriteLine(myClass.Name3);
        }
    }

    internal class MyClass
    {
        public string Name { get; set; }

        public string Name2 { get; private set; }

        public string Name3 { private get; set; } = "Test";

        public string IntMax
        {
            get { return int.MaxValue.ToString(); }
        }

        // public string IntMax2 { set; }

        public string IntMax3 => int.MaxValue.ToString();
    }
}