using System;

namespace NestedTypeSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            
            var myClass2 = new MyClass.MyClass2();
        }
    }

    internal class MyClass
    {
        enum MyEnum
        {
        }

        public class MyClass2
        {
        }

        private interface IInterface
        {
        }
    }
}