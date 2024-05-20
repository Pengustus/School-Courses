namespace Car
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(1, 0.5),
                new Tire(1, 2.3)
            };
            var engine = new Engine(560, 6300);

            Car firstCar = new Car();
            Console.WriteLine($"{firstCar.Make} {firstCar.Model} {firstCar.Year} {firstCar.FuelQuantity} {firstCar.FuelConsumption}");
            Car secondCar = new Car(make, model, year);
            Console.WriteLine($"{secondCar.Make} {secondCar.Model} {secondCar.Year} {secondCar.FuelQuantity} {secondCar.FuelConsumption}");
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine($"{thirdCar.Make} {thirdCar.Model} {thirdCar.Year} {thirdCar.FuelQuantity} {thirdCar.FuelConsumption}");
            Car fourthCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
            Console.WriteLine($"{thirdCar.Make} {thirdCar.Model} {thirdCar.Year} {thirdCar.FuelQuantity} {thirdCar.FuelConsumption} {thirdCar.Engine} {thirdCar.Tire}");
        }
    }
}