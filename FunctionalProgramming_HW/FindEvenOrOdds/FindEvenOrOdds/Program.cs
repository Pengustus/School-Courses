namespace FindEvenOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            Func<int, bool> condition;

            if (input == "even")
                condition = x => x % 2 == 0;
            else
                condition = x => x % 2 != 0;

            List<int> result = Enumerable.Range(nums[0], nums[1] - nums[0]).Where(condition).ToList();

            Console.WriteLine(String.Join(" ", result));
        }
    }
}