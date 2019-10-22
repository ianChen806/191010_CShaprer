using System;
using System.Security.Cryptography;
using System.Text;

namespace MethodSample_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            string result = myClass.Md5Hash("Test");

            string result1 = myClass.Md5Hash("Test", Encoding.UTF8);

            string result2 = myClass.Md5Hash("Test", encoding: Encoding.UTF8);

            // string result3 = myClass.Md5Hash( encoding: Encoding.UTF8,"Test");

            string result4 = myClass.Md5Hash(encoding: Encoding.UTF8, text: "Test");

            string result5 = myClass.Md5Hash("Test", test: new MyClass());

            Console.WriteLine(result);
        }
    }

    internal class MyClass
    {
        private readonly Md5Helper _md5Helper = new Md5Helper();

        public string Md5Hash(string text, Encoding encoding = null, MyClass test = null)
        {
            if(encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            return _md5Helper.Hash(text, encoding);
        }

        public string Md5Hash(int? value = default)
        {
            return "";
        }
    }
}