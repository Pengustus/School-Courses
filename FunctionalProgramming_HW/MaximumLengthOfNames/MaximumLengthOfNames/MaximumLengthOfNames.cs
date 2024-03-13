namespace MaximumLengthOfNames
{
    internal class MaximumLengthOfNames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split().ToArray();
            Func<string, int, bool> func = (n, l) => n.Length <= l;

            foreach (var name in names)
                if (func(name, n))
                    Console.WriteLine(name);
        }
    }
}