using System;

namespace WordsInPlural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Skip(1)
                .Where(x => x.Length < 5)
                .Select(x => x + "s")
                .OrderBy(x => x.Length)
                .ThenBy(x => x, StringComparer.Ordinal)    
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}