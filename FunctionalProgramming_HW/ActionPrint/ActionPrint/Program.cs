namespace ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}