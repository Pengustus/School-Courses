namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }

            names.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{names[i]}");
            }
        }
    }
}