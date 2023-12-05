namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> nums = new Queue<int>(input);
            int length = nums.Count();

            for (int i = 0; i < length; i++)
            {
                if (nums.Peek() % 2 != 0)
                {
                    nums.Dequeue();
                }
                else
                {
                    int evenNum = nums.Dequeue();
                    nums.Enqueue(evenNum);
                }
            }

            Console.WriteLine(String.Join(", ", nums));
        }
    }
}