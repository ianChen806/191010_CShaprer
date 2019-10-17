using System;

namespace FiledSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new KeyGenerate(123);

            var id = myClass.GetKey();

            Console.WriteLine(id);
        }
    }

    internal class KeyGenerate
    {
        private readonly int _id;

        public KeyGenerate(int id)
        {
            _id = id;
        }

        public string GetKey()
        {
            return $"MyClass-{_id}-{DateTime.Now.Ticks}";
        }
    }
}