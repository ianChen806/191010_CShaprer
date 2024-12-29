using System;
using System.Threading;

namespace StaticSample_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for(var count = 0; count < 10; count++)
            {
                try
                {
                    MyClass.GetKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetBaseException().Message);
                }
                Thread.Sleep(100);
            }
        }
    }

    internal static class MyClass
    {
        private readonly static string _key = "123";

        static MyClass()
        {
            var nowTicks = DateTime.Now.Ticks;
            throw new Exception(nowTicks.ToString());
        }

        public static string GetKey()
        {
            return _key;
        }
    }
}
