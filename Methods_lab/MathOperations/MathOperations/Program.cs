namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Calculation(num1, num2, action);
        }

        static void Calculation(double num1, double num2, char action)
        {
            double sum = 0;
            
            switch (action)
            {
                case '+':
                    sum = num1 + num2;
                    break;
                case '*':
                    sum = num1* num2;
                    break;
                case '/':
                    sum = num1 / num1;
                    break;
                case '-':
                    sum = num1 - num2;
                    break;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}