using System.Globalization;

namespace OddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string thing = " ";

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    thing = "False";
                }
                else
                {
                    thing = "True";
                }

                Console.WriteLine($"{nums[i]} is odd - {thing}");
            }    
        }
    }
}