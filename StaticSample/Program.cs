using System;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = MyClass.GetKey();
            Console.WriteLine(key);

            var value = "123";
            var result = value.Md5Hash();
        }
    }

    internal static class MyClass
    {
        private static string _key = "123";

        static MyClass()
        {
            Console.WriteLine("ctor");
        }

        public static string GetKey()
        {
            return _key;
        }
        
        public static string Md5Hash(this string value)
        {
            return Md5Helper.Hash(value);
        }
    }
}