namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = 0;
            Vowels(word, count);
        }

        static void Vowels(string word, int count)
        {
            word = word.ToLower();

            string vowels = "aeiou";

            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }  

            Console.WriteLine(count);
        }
    }
}