using System;

namespace StaticSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var key = MyClass.GetKey();
            Console.WriteLine(key);
        }
    }

    internal static class MyClass
    {
        private readonly static string _key = "123";

        static MyClass()
        {
            Console.WriteLine("ctor");
        }

        public static string GetKey()
        {
            return _key;
        }
    }
}
