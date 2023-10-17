using System.Reflection;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                bool maxNum = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[j]+ " " + num);
                }
            }            
        }
    }
}