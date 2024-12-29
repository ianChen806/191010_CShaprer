using System;

namespace TypeSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var car = new Car();
            car.Name = "Source";

            SetName(car);

            Console.WriteLine(car.Name);
        }

        private static void SetName(Car car)
        {
            car.Name = "Change";
        }
    }

    public class Car
    {
        public string Name { get; set; }
    }
}
