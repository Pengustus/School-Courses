namespace Classification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> contests = new SortedDictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> candidates = new SortedDictionary<string, Dictionary<string, int>>();

            string input = null;

            while ((input = Console.ReadLine()) != "the contests are ended")
            {
                string[] contestType = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contest = contestType[0];
                string pass = contestType[1];

                contests.Add(contest, pass);
            }

            while ((input = Console.ReadLine()) != "the submissions are ended")
            {
                string[] info = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = info[0];
                string pass = info[1];
                string name = info[2];
                int points = int.Parse(info[3]);

                if (contests.ContainsKey(contest) && contests[contest] == pass)
                {
                    if (!candidates.ContainsKey(name))
                        candidates[name] = new Dictionary<string, int>();

                    if (!candidates[name].ContainsKey(contest))
                        candidates[name][contest] = 0;

                    candidates[name][contest] = Math.Max(candidates[name][contest], points);
                }
            }

            var sorted = candidates.OrderBy(candidate => candidate.Key).ThenBy(candidate => candidate.Value.Sum(x => x.Value));          

            var topCandidate = sorted.Last();

            Console.WriteLine($"Candidate number one is {topCandidate.Key} with total {topCandidate.Value.Sum(x => x.Value)} points.");
            Console.WriteLine($"Ranking:");

            foreach (var c in sorted)
            {
                Console.WriteLine(c.Key);

                foreach (var contest in c.Value.OrderByDescending(contest => contest.Value))
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }
    }
}