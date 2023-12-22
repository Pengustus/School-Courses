namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            int sum = queue.Sum();
            int biggest = queue.Max();

            if (sum < n)
            {
                Console.WriteLine(biggest);
                Console.WriteLine("All orders are completed");
            } else
            {
                while (n - queue.Peek() > 0)
                {
                    n -= queue.Peek();
                    queue.Dequeue();                    
                }

                Console.WriteLine(biggest);
                Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
            }   
        }
    }
}