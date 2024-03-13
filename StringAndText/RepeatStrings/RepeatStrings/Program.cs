using System.Text;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                int count = word.Length;
                for (int i = 0; i < count; i++)
                    result.Append(word);
            }

            Console.WriteLine(result.ToString());
        }
    }
}