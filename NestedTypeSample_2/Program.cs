using System;

namespace NestedTypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            var key = myClass.GetKey();

            Console.WriteLine(key);
        }
    }

    internal class MyClass
    {
        private readonly KeyGenerator _keyGenerator = new KeyGenerator();

        public string GetKey()
        {
            return _keyGenerator.Get();
        }

        private class KeyGenerator
        {
            private readonly string _key = "private key";

            public string Get()
            {
                return $"{_key}-{DateTime.Now.Ticks}";
            }
        }
    }
}