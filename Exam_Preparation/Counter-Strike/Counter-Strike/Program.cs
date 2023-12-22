namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string dist = Console.ReadLine();
            int count = 0;

            while (true)
            {               
                if (dist == "End of battle")
                {
                    Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
                    break;
                }

                int dist1 = int.Parse(dist);
                
                if (dist1 <= energy)
                {
                    count++;
                    energy -= dist1;
                    
                    if (count % 3 == 0)
                    {
                        energy += count;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    break;
                }

                dist = Console.ReadLine();
            }
        }
    }
}