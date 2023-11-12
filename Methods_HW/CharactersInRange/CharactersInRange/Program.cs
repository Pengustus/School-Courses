namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Chars(first, second);
        }

        static void Chars(char first, char second)
        {
            char startChar;
            char endChar;

            if (first < second)
            {
                startChar = first;
                endChar = second;
            }
            else
            {
                startChar = second;
                endChar = first;
            }

            for (char i = ++startChar; i < endChar; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}