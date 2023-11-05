namespace LargerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            GetMax(num1, num2);
        }

        static void GetMax(int num1, int num2)
        {
            if (num1 > num2)
                Console.WriteLine(num1);

            if (num2 > num1)
                Console.WriteLine(num2);
        }
    }
}