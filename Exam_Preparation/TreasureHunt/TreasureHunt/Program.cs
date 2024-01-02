namespace TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();

            string command = Console.ReadLine();
            while (command != "Yohoho!")
            {
                command = Console.ReadLine();
                
                string[] ints = command.Split();

                switch (ints[0])
                {
                    case "Loot":

                        for (int i = 1; i < ints.Length; i++)
                        {
                            string item = ints[i];

                            if (!chest.Contains(item))
                            {
                                chest.Insert(0, item);
                            }
                        }

                        break;

                    case "Drop":

                        int index = int.Parse(ints[1]);

                        if (index >= 0 && index < chest.Count)
                        {
                            string dropped = chest[index];
                            chest.RemoveAt(index);
                            chest.Add(dropped);
                        }

                        break;

                    case "Steal":

                        int count = Math.Min(int.Parse(ints[1]), chest.Count);

                        List<string> stolenItems = chest.TakeLast(count).ToList();

                        chest.RemoveRange(chest.Count - count, count);
                        Console.WriteLine(string.Join(", ", stolenItems));

                        break;
                }
            }

            double average = chest.Sum(item => item.Length) / (double)chest.Count;

            if (chest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {average:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}