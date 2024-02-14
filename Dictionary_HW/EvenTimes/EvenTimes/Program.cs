namespace EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (counts.ContainsKey(input))
                {
                    counts[input]++;
                }
                else
                {
                    counts[input] = 1;
                }
            }

            foreach (var i in counts)
            {
                if (i.Value % 2 == 0)
                {
                    Console.WriteLine(i.Key);
                }
            }
        }
    }
}