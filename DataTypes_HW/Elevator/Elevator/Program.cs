namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int trips = (people / capacity);

            Console.WriteLine($"{trips+1}");
        }
    }
}