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

            Car car = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
        }
    }
}