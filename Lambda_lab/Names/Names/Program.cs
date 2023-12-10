namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (name.Length >= 3 && char.IsUpper(name[0]) && !Digit(name))
            {
                Console.WriteLine($"Hello, {name}!");

                foreach (char character in name)
                {
                    int asciiValue = character + 10;
                    Console.WriteLine($"{asciiValue}");
                }
            }
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }

        static bool Digit(string name)
        {
            foreach (char character in name)
            {
                if (char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }
    }
}