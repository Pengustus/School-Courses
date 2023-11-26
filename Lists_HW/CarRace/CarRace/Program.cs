namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double racer1time = 0;
            double racer2time = 0;

            Calculate(racer1time, racer2time, nums);
        }

        static void Calculate(double racer1time, double racer2time, List<int> nums)
        {
            for (int i = 0; i < nums.Count / 2; i++)
            {
                if (nums[i] == 0)
                {
                    racer1time *= 0.8;
                }
                if (nums[nums.Count - 1 - i] == 0)
                {
                    racer2time *= 0.8;
                }

                racer1time += nums[i];
                racer2time += nums[nums.Count - 1 - i];
            }

            if (racer1time < racer2time && Math.Floor(racer1time) == racer1time)
            {
                Console.WriteLine($"The winner is left with total time: {racer1time}");
            }

            if (racer1time < racer2time && Math.Floor(racer1time) != racer1time)
            {
                Console.WriteLine($"The winner is left with total time: {racer1time:F1}");
            }

            if (racer1time > racer2time && Math.Floor(racer2time) != racer2time)
            {
                Console.WriteLine($"The winner is right with total time: {racer2time:F1}");
            }

            if (racer1time > racer2time && Math.Floor(racer2time) == racer2time)
            {
                Console.WriteLine($"The winner is right with total time: {racer2time}");
            }
        }
    }
}