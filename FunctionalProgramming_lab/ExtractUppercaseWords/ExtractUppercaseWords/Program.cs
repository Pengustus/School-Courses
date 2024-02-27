namespace ExtractUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            var input = Console.ReadLine().Split().Where(checker).ToArray();

            foreach(string i in input)
                Console.WriteLine(i);
        }
    }
}