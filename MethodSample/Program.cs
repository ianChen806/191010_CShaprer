using System;

namespace MethodSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculation
    {
        public int Add_1(int first, int second)
        {
            return first + second;
        }

        protected int Add_2(int first, int second)
        {
            return first + second;
        }

        private int Add_3(int first, int second)
        {
            return first + second;
        }

        internal int Add_4(int first, int second)
        {
            return first + second;
        }
    }
}