namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Calculate(num1, num2, num3);
        }

        static void Calculate(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);
            }

            if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2);
            }

            if (num3 < num2 && num3 < num1)
            {
                Console.WriteLine(num3);
            }
        }
    }
}