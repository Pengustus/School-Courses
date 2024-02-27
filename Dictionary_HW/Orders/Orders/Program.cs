namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> specs = new Dictionary<string, Dictionary<double, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0].ToLower() == "buy")
                {
                    break;
                }

                if (specs.ContainsKey(input[0]))
                {

                }
            }
        }
    }
}