using System;

namespace OneClass
{
    internal class MyClass
    {
        private event EventHandler Event;

        private readonly string _name;

        public MyClass(string name)
        {
            Console.WriteLine("start");
            _name = name;
        }

        public string Id { private get; set; }

        public string GetName()
        {
            return $"Name = {Id}{_name}";
        }

        protected virtual void OnEvent()
        {
            Event?.Invoke(this, EventArgs.Empty);
        }

        ~MyClass()
        {
            Console.WriteLine("end");
        }
    }
}