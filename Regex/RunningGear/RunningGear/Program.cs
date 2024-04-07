using System.Globalization;
using System.Text.RegularExpressions;

namespace RunningGear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<>(?<name>[a-zA-Z\s]+)<>(?<quantity>\d+)--(?<price>[0-9.]+)");
            List<string> gears = new List<string>();
            double total = 0;
            string input = Console.ReadLine();           

            while (true)
            {
                if (input == "Run!")
                {
                    break;
                }
                
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    
                    string name = match.Groups["name"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    gears.Add(name);
                    total += quantity * price;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Gear bought:");
            foreach (string gear in gears)
            {
                Console.WriteLine(gear);
            }
            Console.WriteLine($"Total cost: {total:F2}");
        }
    }
}