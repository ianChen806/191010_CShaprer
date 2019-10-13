namespace CSharper_1
{
    public class PrimitiveType
    {
        void Main()
        {
            int a1 = 1;
            
            System.Int32 a2 = 1;
            
            int a3 = new int();
            
            System.Int32 a4 = new System.Int32();
        }
    }

    internal class MyClass
    {
        public string Name { get; set; }
    }

    internal struct MyStruct
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}