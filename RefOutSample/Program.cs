using System;

namespace RefOutSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();

            var value1 = 1;
            myClass.Ref(ref value1);
            Console.WriteLine($"value1 = {value1}");

            var value2 = 1;
            myClass.Out(out value2);
            Console.WriteLine($"value2 = {value2}");
        }
    }

    internal class MyClass
    {
        public void Out(out int value2)
        {
            value2 = 10;
        }

        public void Ref(ref int value)
        {
            value = 5;
        }
    }
}
