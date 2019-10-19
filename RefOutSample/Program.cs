using System;

namespace RefOutSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            int value1 = 1;
            myClass.Ref(ref value1);
            Console.WriteLine($"value1 = {value1}");

            int value2;
            myClass.Out(out value2);
            Console.WriteLine($"value2 = {value2}");
        }
    }

    internal class MyClass
    {
        public void Ref(ref int value)
        {
            value = 5;
        }

        public void Out(out int value2)
        {
            value2 = 10;
        }
    }
}