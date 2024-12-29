namespace FieldSample_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass(new MyClass2());
        }
    }

    internal class MyClass
    {
        private readonly MyClass2 _value;

        public MyClass(MyClass2 value)
        {
            _value = value;
        }

        private void Test()
        {
            _value.Name = "Test";

            // _value = new MyClass2();
        }
    }

    internal class MyClass2
    {
        public string Name { get; set; }
    }
}
