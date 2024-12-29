namespace NestedTypeSample_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();

            var myClass2 = new MyClass.MyClass2();
        }
    }

    internal class MyClass
    {
        private enum MyEnum
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
