namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int kratno = int.Parse(Console.ReadLine());
            Func<List<int>, List<int>> func = n => n.Where(n => n % kratno != 0).ToList();
            Console.WriteLine($"{String.Join(" ", func(nums))}");
        }
    }
}