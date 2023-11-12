using System.Globalization;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            Numbers(pass);
            Specials(pass);
            Chars(pass);

            bool chars1 = Chars(pass);
            bool specials1 = Specials(pass);
            bool numbers1 = Numbers(pass);

            if (chars1 == true && specials1 == false && numbers1 == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool Chars(string pass)
        {
            bool chars = false;
            
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                chars = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            return chars;
        }

        static bool Specials(string pass)
        {
            bool specials = false;
            
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (char c in pass)
            {
                if (specialChar.Contains(c))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    specials = true;
                    break;
                }
            }

            return specials;
        }

        static bool Numbers(string pass)
        {
            bool numbers = false;
            
            int digitCount = pass.Count(char.IsDigit);
            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                numbers = true;
            }

            return numbers;
        }
    }
}