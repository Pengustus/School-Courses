namespace Cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string snack = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            Price(snack, amount);
        }

        static void Price(string snack, int amount)
        {
            double price = 0;
            
            switch (snack)
            {
                case "water":
                    price = 1; break;
                case "coke":
                    price = 1.4; break;
                case "coffee":
                    price = 1.5; break;
                case "snacks":
                    price = 2; break;
            }

            double finalPrice = price * amount;
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}