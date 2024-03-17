namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { '\\', '.' };
            if (!input.Contains("\\"))
                separators = new char[] { '.' };

            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = words.Length;
            Console.WriteLine($"File name: {words[count-1]}");
            Console.WriteLine($"File extension: {words[count]}");
        }
    }
}