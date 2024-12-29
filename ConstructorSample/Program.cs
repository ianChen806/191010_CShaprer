namespace Constructor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass1 = new MyClass1();

            var myClass2 = new MyClass2();
            var myClass22 = new MyClass2(1, "test");

            var myClass3 = new MyClass3(1, "test");

            // var myClass33 = new MyClass3(); // build error.
        }
    }

    internal class MyClass1
    {
    }

    internal class MyClass2
    {
        public MyClass2()
        {
        }

        public MyClass2(int id, string name)
        {
        }
    }

    internal class MyClass3
    {
        public MyClass3(int i, string test)
        {
        }
    }
}
