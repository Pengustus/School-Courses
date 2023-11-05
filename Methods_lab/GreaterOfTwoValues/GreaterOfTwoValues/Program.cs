using System.Diagnostics.SymbolStore;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Number(num1, num2);
                    break;

                case "char":
                    char sym1 = char.Parse(Console.ReadLine());
                    char sym2 = char.Parse(Console.ReadLine());
                    Character(sym1, sym2);
                    break;

                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Text(str1, str2);
                    break;
            }
        }

        static void Number(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        static void Character(char sym1, char sym2)
        {
            if (sym1 < sym2)
            {
                Console.WriteLine(sym1);
            }
            else
            {
                Console.WriteLine(sym2);
            }
        }

        static void Text(string str1, string str2)
        {
            int str10 = string.Compare(str1, str2);

            if (str10 == -1)
            {
                Console.WriteLine(str2);
            }
            
            if (str10 == 1)
            {
                Console.WriteLine(str1);
            }
        }
    }
}