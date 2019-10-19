using System;
using System.Linq;

namespace MethodSample_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var result = myClass.Add("Total", 1, 2, 3, 4, 5);

            Console.WriteLine(result);
        }
    }

    internal class MyClass
    {
        public string Add(string key, params int[] values)
        {
            return $"{key}={values.Sum()}";
        }

        // public string Add(params int[] values, string key)
        // {
        //     return $"{key}={values.Sum()}";
        // }
    }
}