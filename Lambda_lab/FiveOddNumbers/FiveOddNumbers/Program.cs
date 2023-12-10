namespace FiveOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % 2 != 0)
            .OrderByDescending(x => x)
            .Take(5)
            .ToArray();

            Console.WriteLine($"{string.Join(" ", nums)}");
        }
    }
}