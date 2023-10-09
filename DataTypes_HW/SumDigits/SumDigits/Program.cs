﻿namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            while (input > 0)
            {
                int lastNum = input % 10;
                sum += lastNum;
                input /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}