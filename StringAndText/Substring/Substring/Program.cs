using System.Globalization;
using System.Net.Security;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine().ToLower();
            string word = Console.ReadLine();

            int index = word.IndexOf(remove);

            while (index != -1)
            {
                word = word.Remove(index, remove.Length);
                index = word.IndexOf(remove);
            }

            Console.WriteLine(word);
        }
    }
}