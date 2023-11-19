using System;

namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int listLength = nums.Count;

            Ints(nums, listLength);

            Console.WriteLine(string.Join(" ", nums));
        }

        static List<int> Ints(List<int> nums, int listLength)
        {
            for (int i = 0; i < listLength / 2; i++)
            {
                nums[i] += nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
            }

            return nums;
        }
    }
}