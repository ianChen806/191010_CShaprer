using System;

namespace RefOutSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            int value1 = 1;
            myClass.Ref(value1);
            Console.WriteLine($"value1 = {value1}");

            int value2 = 1;
            myClass.Out(value2);
            Console.WriteLine($"value2 = {value2}");
        }
    }

    internal class MyClass
    {
        public void Ref(int value)
        {
            value = 5;
        }

        public void Out(int value2)
        {
            // value2 = 10;
        }
    }
}