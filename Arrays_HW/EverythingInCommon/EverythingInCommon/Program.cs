namespace EverythingInCommon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool areSame = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    sum = i;
                    Console.WriteLine("Arrays are not identical.");
                    Console.WriteLine($"Found difference at {sum} index");
                    break;
                }

                sum = arr1[i];

                if (i == arr1.Length - 1 && i == arr2.Length - 1)
                {
                    areSame = true;
                }

                if (areSame == true)
                {
                    int lastNum = arr1[i] % 10;
                    sum += lastNum;

                    Console.WriteLine("Arrays are identical.");
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }

        }
    }
}