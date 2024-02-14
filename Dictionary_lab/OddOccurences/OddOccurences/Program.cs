namespace OddOccurences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lower = word.ToLower();
                
                if (counts.ContainsKey(lower))
                {
                    counts[lower]++;
                }
                else
                {
                    counts.Add(lower, 1);
                }
            }

            foreach (var pair in counts.Where(pair => pair.Value % 2 != 0))
            {
                    Console.Write(pair.Key + " ");
            }
        }
    }
}