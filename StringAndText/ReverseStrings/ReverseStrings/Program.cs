namespace ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            while (true)
            {
                                
                string reversed = "";

                for (int i = word.Length - 1; i >= 0; i--)
                    reversed += word[i];

                if (word == "end")
                    break;
                    
                Console.WriteLine($"{word} = {reversed}");

                word = Console.ReadLine();
            } 
        }
    }
}