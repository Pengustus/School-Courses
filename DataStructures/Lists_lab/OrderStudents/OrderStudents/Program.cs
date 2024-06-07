using System.Collections.Generic;

namespace OrderStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(string.Join(" ", NoSpaces(nums)));
        }

        static List<int> NoSpaces(List<string> nums)
        {
            nums.Reverse();
            List<int> result = new List<int>();

            foreach (string s in nums)
            {
                result.AddRange(s
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            return result;
        }
    }
}