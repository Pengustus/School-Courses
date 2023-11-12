namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal num01 = Factorial(num1);
            decimal num02 = Factorial2(num2);

            decimal finalNum = num01 / num02;
            Console.WriteLine($"{finalNum:F2}");
        }

        static decimal Factorial(int num1)
        {
            decimal fac = 1;
            
            for (int i = 1; i <= num1; i++)
            {
                fac = fac * i;
            }

            decimal fac1 = fac;

            return fac1;
        }

        static decimal Factorial2(int num2)
        {
            decimal fac = 1;

            for (int i = 1; i <= num2; i++)
            {
                fac = fac * i;
            }

            decimal fac2 = fac;

            return fac2;
        }
    }
}