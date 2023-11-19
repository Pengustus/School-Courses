namespace RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Action(nums);

            Console.WriteLine(String.Join(" ", nums));
        }

        static List<int> Action(List<int> nums)
        {
            nums.RemoveAll(n => n < 0);

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();                
            }

            return nums;
        }
    }
}