namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> nums2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            Stack<int> ints = new Stack<int>(nums2);

            for (int i = 0; i < nums[1]; i++)
            {
                ints.Pop();
            }

            if (ints.Contains(nums[2]))
            {
                Console.WriteLine("found");
            }
            else
            {
                int min = ints.Min();
                Console.WriteLine(min);
            }

        }
    }
}