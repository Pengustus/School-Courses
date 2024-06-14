using static System.Formats.Asn1.AsnWriter;

namespace CivilizationVI
{
    internal class Civ6
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> campuses = new Dictionary<string, int[]>();

            string input;

            while ((input = Console.ReadLine()) != "Build")
            {
                string[] parts = input.Split("---");
                string city = parts[0];
                int facilities = int.Parse(parts[1]);
                int scienceScore = int.Parse(parts[2]);

                if (campuses.ContainsKey(city))
                {
                    campuses[city][0] += facilities;
                    campuses[city][1] += scienceScore;
                }
                else
                {
                    campuses[city] = new int[] { facilities, scienceScore };
                }
            }

            string commandInput;

            while ((commandInput = Console.ReadLine()) != "End")
            {
                string[] tokens = commandInput.Split(">>");
                string command = tokens[0];
                string city = tokens[1];

                if (!campuses.ContainsKey(city)) continue;

                switch (command)
                {
                    case "Boost":
                        int scienceBoost = int.Parse(tokens[2]);
                        if (scienceBoost < 0)
                        {
                            Console.WriteLine("Score cannot be boosted with a negative amount!");
                        }
                        else
                        {
                            campuses[city][1] += scienceBoost;
                            Console.WriteLine($"{scienceBoost} science boost added to the Campus in {city}. The Campus now has total science score: {campuses[city][1]}.");
                        }
                        break;
                    case "Sabotage":
                        int FacilitiesSabotaged = int.Parse(tokens[2]);
                        int scoreSabotaged = int.Parse(tokens[3]);

                        campuses[city][0] -= FacilitiesSabotaged;
                        campuses[city][1] -= scoreSabotaged;
                        Console.WriteLine($"Campus in {city} is sabotaged! You now have {FacilitiesSabotaged} less functioning facilities and decreased with {scoreSabotaged} science score.");

                        if (campuses[city][0] <= 0 || campuses[city][1] <= 0)
                        {
                            campuses.Remove(city);
                            Console.WriteLine($"The campus in {city} has been destroyed!");
                        }
                        break;
                }
            }

            if (campuses.Count > 0)
            {
                var sortedCampuses = campuses.OrderByDescending(c => c.Value[1]).ThenBy(c => c.Key).ToList();
                Console.WriteLine($"You have {sortedCampuses.Count} Campuses discovering science:");
                foreach (var campus in sortedCampuses)
                {
                    Console.WriteLine($"{campus.Key} -> Facilities: {campus.Value[0]}, Science score: {campus.Value[1]}");
                }
            }
            else
            {
                Console.WriteLine("Pity! All Campuses have been sabotaged and destroyed!");
            }
        }
    }
}