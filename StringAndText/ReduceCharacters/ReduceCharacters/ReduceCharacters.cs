using System.Text;

namespace ReduceCharacters
{
    internal class ReduceCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            string vowels = "aeiou";
            string result = null;

            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    result += c;
                }
            }

            Console.WriteLine(result);
        }  
    }
}