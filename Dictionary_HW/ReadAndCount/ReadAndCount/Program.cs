using System.Globalization;

namespace ReadAndCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, int> minerals = new SortedDictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "mineral")
                {
                    foreach (string word in input)
                    {
                        if (minerals.ContainsKey(word) && word != "mineral")
                        {
                            minerals[word]++;
                        }
                        else
                        {
                            if (word != "mineral")
                            {
                                minerals[word] = 1;
                            }                           
                        }
                    }
                }
            }

            foreach (var word in minerals)
            {
                Console.WriteLine($"{word.Key}: {word.Value} time/s");
            }
        }
    }
}