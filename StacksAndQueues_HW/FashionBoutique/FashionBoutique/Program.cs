namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (int item in input.Reverse())
                clothes.Push(item);

            int capacity = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 1;

            while (clothes.Count > 0)
            {
                if (sum + clothes.Peek() <= capacity)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    sum = clothes.Pop();
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}