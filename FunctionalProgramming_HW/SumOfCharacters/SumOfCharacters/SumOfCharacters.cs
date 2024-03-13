namespace SumOfCharacters
{
    internal class SumOfCharacters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int> sum = s => s.Select(c => (int)c).Sum();
            Func<List<string>, int, Func<string, int>, string> check = (names, n, sum) => names.FirstOrDefault(p => sum(p) >= n);
            Console.WriteLine(check(names, n, sum));
        }
    }
}