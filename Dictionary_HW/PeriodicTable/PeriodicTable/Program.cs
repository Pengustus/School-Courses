using System.Globalization;

namespace PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> counts = new HashSet<string>();
            SortedDictionary<string, int> chem = new SortedDictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!counts.Contains(input[j]))
                        counts.Add(input[j]);
                }
                
            }

            foreach (var count in counts)
            {
                chem.Add(count, 1);
            }

            foreach (var input in chem)
            {
                Console.Write($"{input.Key} ");
            }
        }
    }
}