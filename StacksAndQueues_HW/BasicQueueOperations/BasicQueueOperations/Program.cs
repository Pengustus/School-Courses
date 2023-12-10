namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int input1 = input[1];
            int input2 = input[2];

            Queue<int> numQueue = new Queue<int>(
                Console.ReadLine().Split().Select(int.Parse)
            );

            for (int i = 0; i < input1 && numQueue.Count > 0; i++)
            {
                numQueue.Dequeue();
            }

            if (numQueue.Count > 0)
            {
                if (numQueue.Contains(input2))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numQueue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}