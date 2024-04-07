using System.Text;

namespace FindData
{
    internal class FindData
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int first = input.IndexOf("@");
                int second = input.IndexOf("|");
                int third = input.IndexOf("#");
                int fourth = input.IndexOf("*");

                string name = input.Substring(first + 1, (second - first) - 1);
                string age = input.Substring(third + 1, (fourth - third) - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}