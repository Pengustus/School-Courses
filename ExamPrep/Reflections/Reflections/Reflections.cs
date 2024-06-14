using System.Text.RegularExpressions;

namespace Reflections
{
    internal class Reflections
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";

            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, pattern);

            List<string> valid = new List<string>();
            List<string> mirrored = new List<string>();

            foreach (Match match in matches)
            {
                string first = match.Groups[2].Value;
                string second = match.Groups[3].Value;
                valid.Add($"{first} <=> {second}");
                if (IsMirror(first, second))
                {
                    mirrored.Add($"{first} <=> {second}");
                }
            }

            if (valid.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{valid.Count} word pairs found!");
            }

            if (mirrored.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrored));
            }           
        }

        static bool IsMirror(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }

            int length = first.Length;
            for (int i = 0; i < length; i++)
            {
                if (first[i] != second[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}