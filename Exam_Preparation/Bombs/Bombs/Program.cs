namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] effects = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] casings = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(effects);
            Stack<int> stack = new Stack<int>(casings);

            int datura = 0;
            int cherry = 0;
            int smoke = 0;

            bool allBombs = false;

            while (stack.Count > 0 && queue.Count > 0)
            {
                int effect = queue.Peek();
                int casing = stack.Peek();

                if (effect + casing == 40)
                {
                    datura++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (effect + casing == 60)
                {
                    cherry++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (effect + casing == 120)
                {
                    smoke++;
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    stack.Pop();
                    stack.Push(casing - 5);
                }


                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    allBombs = true;
                    break;
                }
            }

            if (allBombs)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", queue)}");

            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", stack)}");

            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}