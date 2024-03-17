using System.Text;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            StringBuilder result = new StringBuilder();
            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16
                    && !username.Contains("_") && !username.Contains("-") && Check(username))
                {
                    result.AppendLine(username);
                }
            }
            Console.WriteLine(result.ToString());
        }

        static bool Check(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c) && c != '-' && c != '_')
                    return false;
            }
            return true;
        }
    }
}