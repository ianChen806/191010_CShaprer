using System;
using System.Linq;

namespace MethodSample_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();
            var result = myClass.Add(
                1, 2, 3, 4, 5);

            var result1 = myClass.Add(1, 2, 3, 4);

            Console.WriteLine(result);
        }
    }

    internal class MyClass
    {
        public string Add(params int[] values)
        {
            return $"key={values.Sum()}";
        }

        public string Add(int key, params int[] values)
        {
            return $"{key}={values.Sum()}";
        }

        // public string Add(params int[] values, string key)
        // {
        //     return $"{key}={values.Sum()}";
        // }
    }
}
