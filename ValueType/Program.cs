using System;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            // ChangeValue();

            NewVariable();
        }

        private static void NewVariable()
        {
            var myStruct = new MyStruct();

            var myStruct2 = myStruct;

            var referenceEquals = object.ReferenceEquals(myStruct, myStruct2);

            Console.WriteLine(referenceEquals);
        }

        private static void ChangeValue()
        {
            var myStruct = new MyStruct();
            myStruct.Name = "Source";

            SetName(myStruct);

            Console.WriteLine(myStruct.Name);
        }

        private static void SetName(MyStruct myStruct)
        {
            myStruct.Name = "Change";
        }
    }

    public struct MyStruct
    {
        public string Name { get; set; }
    }
}