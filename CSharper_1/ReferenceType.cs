namespace CSharper_1
{
    public class ReferenceType
    {
        private string Test()
        {
            var car = new Car();

            car.Name = "Source";
            var name = GetName(car);

            return name;
        }

        private string GetName(Car car)
        {
            car.Name = "Change";
            return car.Name;
        }
    }

    public class Car
    {
        public string Name { get; set; }
    }
}