namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());         
            
            for (int i = 0; i < num; i++)
            {
                if (DivideByEight(i) && OddNum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        static bool DivideByEight(int num)
        {
            bool odd = false;

            int sum = 0;

            while (num > 0)
            {
                int lastNum = num % 10;
                sum += lastNum;
                num /= 10;
            }

            if (sum % 8 == 0)
            {
                odd = true;
            }

            return odd;            
        }

        static bool OddNum(int num)
        {
            bool odd = false;

            while (num > 0)
            {
                int lastNum = num % 10;

                if (lastNum % 2 != 0)
                {
                    odd = true;
                    break;
                }

                num /= 10;
            }

            return odd;
        }
    }
}