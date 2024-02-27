namespace RepeatedNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i <= n; i++)
            {
                string word = Console.ReadLine();

                names.Add(word);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}