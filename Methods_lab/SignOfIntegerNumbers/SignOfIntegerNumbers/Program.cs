namespace SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Number(num);
        }

        static void Number(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }

            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }

            if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}