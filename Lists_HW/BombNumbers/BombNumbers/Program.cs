namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int specialNum = bomb[0];
            int power = bomb[1];

            DetonateNums(nums, specialNum, power);

            Console.WriteLine(nums.Sum());
        }

        static void DetonateNums(List<int> numbers, int bombNumber, int power)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    DetonateBomb(numbers, i, power);
                    i = Math.Max(i - power, 0);
                }
            }
        }

        static void DetonateBomb(List<int> numbers, int index, int power)
        {
            int leftSide = Math.Max(0, index - power);
            int rightSide = Math.Min(numbers.Count - 1, index + power);

            numbers.RemoveRange(leftSide, rightSide - leftSide + 1);
        }
    }
}