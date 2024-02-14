namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> counts = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                decimal grade = decimal.Parse(info[1]);

                if (!counts.ContainsKey(name))
                {
                    counts.Add(name, new List<decimal>());
                    counts[name].Add(grade);
                }
                else
                {
                    counts[name].Add(grade);
                }
            }

            foreach (var count in counts)
            {
                Console.Write($"{count.Key} -> ");
                count.Value.ForEach(x => Console.Write($"{x:f2} "));
                Console.WriteLine($"(avg: {count.Value.Average():f2})");
            }
        }
    }
}