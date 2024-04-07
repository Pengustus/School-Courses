﻿namespace CalculationsWithCharacters
{
    internal class CalcWithChars
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
 
            if (input[0].Length == input[1].Length)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    sum += input[0][i] * input[1][i];
                }
            }
            else
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    sum += input[0][i];
                }

                for (int i = 0; i < input[1].Length; i++)
                {
                    sum += input[1][i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}