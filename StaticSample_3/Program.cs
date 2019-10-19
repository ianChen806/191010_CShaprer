using System;

namespace StaticSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "Test";
            var md5Hash = value.Md5Hash();

            Console.WriteLine(md5Hash);
        }
    }

    internal static class MyClass
    {
        public static string Md5Hash(this string value)
        {
            return Md5Helper.Hash(value);
        }
    }
}