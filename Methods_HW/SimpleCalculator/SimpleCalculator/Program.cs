namespace SimpleCalculator
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
            int sum = num1 + num2;
            int sub = sum - num3;
            Console.WriteLine(sub);
        }
    }
}