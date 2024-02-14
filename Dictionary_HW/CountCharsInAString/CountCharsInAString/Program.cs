namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (counts.ContainsKey(ch))
                    {
                        counts[ch]++;
                    }
                    else
                    {
                        counts.Add(ch, 1);
                    }
                }
            }

            foreach (var ch in counts)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }              
        }
    }
}