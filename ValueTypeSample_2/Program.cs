using System;

namespace ValueTypeSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStruct = new MyStruct();

            var myStruct2 = myStruct;

            var referenceEquals = object.ReferenceEquals(myStruct, myStruct2);

            Console.WriteLine(referenceEquals);
        }
    }

    internal struct MyStruct
    {
        public string Name { get; set; }
    }
}