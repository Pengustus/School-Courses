using System.Globalization;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotMain();
        }

        static void NotMain()
        {
            while (true)
            {
                string num = Console.ReadLine();

                if (num == "END")
                {
                    break;
                }

                char[] chars = num.ToCharArray();
                string reverse = String.Empty;

                for (int i = chars.Length - 1; i > -1; i--)
                {
                    reverse += chars[i];
                }

                if (reverse == num)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}