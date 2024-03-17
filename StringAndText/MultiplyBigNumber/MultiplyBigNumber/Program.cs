namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            int c = 0;
            string result = null;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int digit = num1[i] - '0';
                int product = digit * num2 + c;
                c = product / 10;
                result = (product % 10) + result;
            }

            if (c > 0)
            {
                result = c + result;
            }
                
            result = result.TrimStart('0');
            Console.WriteLine(result);
        }
    }
}