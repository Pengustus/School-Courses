namespace BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunder = int.Parse(Console.ReadLine());
            double expected = double.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                total += plunder;

                if (i % 3 == 0)
                {
                    total += plunder * 0.5;
                }
                
                if (i % 5 == 0)
                {
                    total *= 0.7;
                }
            }

            if (total >= expected)
            {
                Console.WriteLine($"Ahoy! {total:F2} plunder gained.");
            }
            else
            {
                double percentage = (total / expected) * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}