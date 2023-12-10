namespace EvenTransformations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
            .Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .Select(x => x + 1)
            .OrderBy(x => x)
            .ToArray();

            Console.WriteLine($"{string.Join(" ", nums)}");
        }
    }
}