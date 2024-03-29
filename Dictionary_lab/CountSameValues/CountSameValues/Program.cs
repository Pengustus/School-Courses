﻿namespace CountSameValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> counts = new Dictionary<double, int>();

            foreach (double num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times   ");
            }
        }
    }
}