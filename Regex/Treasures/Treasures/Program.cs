using System.Text.RegularExpressions;

namespace Treasures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Match matchMetal = Regex.Match(input, @"@(?<metal>[a-zA-Z]+)\|");
            Match matchGem = Regex.Match(input, @"#(?<gem>[a-zA-Z]+)\*");

            string metal = matchMetal.Groups["metal"].Value;
            string gem = matchGem.Groups["gem"].Value;

            Console.WriteLine($"Found hidden {metal} and {gem} in the cave.");
        }
    }
}