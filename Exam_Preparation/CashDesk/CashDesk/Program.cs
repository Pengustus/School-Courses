namespace CashDesk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] eff = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int clients = int.Parse(Console.ReadLine());

            int perhour = eff[0] + eff[1] + eff[2];
            int hour = 0;

            while (clients > 0)
            {
                if (hour % 4 == 0)
                {
                    clients += perhour;
                }

                if (perhour != clients)
                {
                    clients -= perhour;
                }
                else
                {
                    clients -= perhour;
                }
                
                hour++;
            }

            Console.WriteLine($"Time needed: {hour-1}h.");
        }
    }
}