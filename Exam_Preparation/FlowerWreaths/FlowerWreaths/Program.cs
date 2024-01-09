namespace FlowerWreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> worms = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> holes = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int matching = 0;

            while (worms.Count > 0 && holes.Count > 0)
            {
                int currentWorm = worms.Pop();
                int currentHole = holes.Peek();

                if (currentWorm == currentHole)
                {
                    matching++;
                    holes.Dequeue();
                }
                else
                {
                    holes.Dequeue();

                    currentWorm -= 3;

                    if (currentWorm > 0)
                    {
                        worms.Push(currentWorm);
                    }
                }
            }

            if (matching > 0)
            {
                Console.WriteLine($"Matches: {matching}");
            }
            else
            {
                Console.WriteLine("There are no matches");
            }

            if (worms.Count == matching && matching > 0)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else if (worms.Count == 0)
            {
                Console.WriteLine("Worms left: none");
            }
            else
            {
                Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
            }

            if (holes.Count <= 0)
            {
                Console.WriteLine("Holes left: none ");
            }
            else
            {
                Console.WriteLine($"Holes left: {String.Join(" ", holes)}");
            }
        }
    }
}