﻿using System;

namespace PropertySample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Count = 1;

            //myClass.Count = -1; // throw exception;
        }
    }

    internal class MyClass
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                if (_count < 0)
                {
                    throw new ArgumentException();
                }
                _count = value;
            }
        }
    }
}