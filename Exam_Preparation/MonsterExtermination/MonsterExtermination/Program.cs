namespace MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] armor = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] strike = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(armor);
            Queue<int> queue = new Queue<int>(strike);
            int remaining = 0;

            while (queue.Count > 0)
            {
                if (queue.Peek() >= stack.Peek() || queue.Peek() + remaining >= stack.Peek())
                {
                    remaining += queue.Peek() - stack.Peek();
                    stack.Pop();
                }
                else
                {

                }
            }
        }
    }
}