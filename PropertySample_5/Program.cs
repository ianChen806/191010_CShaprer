using System;

namespace PropertySample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Hour = 23;
            myClass.Minute = 59;
            myClass.Second = 58;
            // myClass.Hour = 30; //exception

            Console.WriteLine(myClass.Time);
        }
    }

    internal class MyClass
    {
        private int _hour;
        private int _minute;
        private int _second;

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value > 24)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get => _minute;
            set
            {
                if (value > 60)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        public int Second
        {
            get => _second;
            set
            {
                if (value > 60)
                {
                    throw new ArgumentException();
                }
                _second = value;
            }
        }

        public string Time => $"{_hour}:{_minute}:{_second}";
    }
}