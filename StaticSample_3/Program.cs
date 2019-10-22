using System;

namespace StaticSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "Test";
            var md5Hash = value.Md5Hash();

            int.TryParse("1", out var a);
            Console.WriteLine(md5Hash);
        }
    }

    internal static class MyClassExtension
    {
        public static string Md5Hash(this string value)
        {
            return Md5Helper.Hash(value);
        }
    }
}