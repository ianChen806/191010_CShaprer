namespace InternalSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    internal class InternalClass
    {
        public int Id { get; set; }

        private class MyClass
        {

        }
    }

    public class PublicClass
    {
        public int Id { get; set; }
    }
}
