namespace WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> worms = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> holes = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int matching = 0;

            while (holes.Count > 0)
            {
                int currentWorm = worms.Pop();  

                if (currentWorm == holes.Peek())
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

            Console.WriteLine(matching > 0 ? $"Matches: {matching}" : "There are no matches.");

            if (worms.Count == matching)
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

            Console.WriteLine(holes.Count == 0 ? "Holes left: none" : $"Holes left: {string.Join(", ", holes)}");

        }
    }
}