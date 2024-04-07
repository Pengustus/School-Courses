using System.Text.RegularExpressions;

namespace ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<name>[\w]+)<<(?<price>[\d]+?(.)?[\d]+)!(?<quantity>[\d]+)");
            List<string> furniture = new List<string>();
            double total = 0;
            string input = Console.ReadLine();
            
            while (input.ToLower() != "purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(Console.ReadLine());

                    furniture.Add(name);
                    total += quantity * price;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (string f in furniture)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine($"Total money spent: {total:F2}");
        }
    }
}                       