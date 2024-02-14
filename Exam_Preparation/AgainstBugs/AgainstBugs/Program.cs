using System.Collections.Generic;

namespace AgainstBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int days = CalculateDays(n, plants);
            Console.WriteLine(days);
        }

        static int CalculateDays(int n, int[] plants)
        {
            int days = 0;
            while (true)
            {
                bool deadPlants = false;
                for (int i = 1; i < n; i++)
                {
                    if (plants[i] > plants[i - 1])
                    {
                        plants[i] = plants[i - 1];
                        deadPlants = true;
                    }
                }
                if (!deadPlants)
                    break;
                days++;
            }
            return days;
        }
    }
}