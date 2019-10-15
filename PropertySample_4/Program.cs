using System;
using System.Reflection;

namespace PropertySample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var methodInfos = myClass.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in methodInfos)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    internal class MyClass
    {
        public string Name { get; set; }
    }
}