using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace BestHero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> heroes = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> votes = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "end")
                {
                    break;
                }

                var heroMatch = Regex.Matches(input, @"[a-zA-Z]");
                var voteMatch = Regex.Matches(input, @"[\d]");

                string name = string.Concat(heroMatch.Select(match => match.Value));
                int votePoints = voteMatch.Select(match => int.Parse(match.Value)).Sum();

                if (heroes.Contains(name))
                {
                    if (!votes.ContainsKey(name))
                    {
                        votes[name] = 0;
                    }
                    votes[name] += votePoints;
                }

                input = Console.ReadLine();
            }

            var topHeroes = votes.OrderByDescending(h => h.Value).Take(3);

            foreach (var hero in topHeroes)
            {
                Console.WriteLine($"{hero.Key}");
            }
        }
    }
}