namespace SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> set = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            List<int> list = new List<int>();

            for (int i = 0; i < size[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set.Add(num);
            }

            for (int i = 0; i < size[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set2.Add(num);
            }

            foreach (int num in set)
            {
                if (set2.Contains(num))
                {
                    list.Add(num);
                }
            }

            Console.WriteLine($"{String.Join(" ", list)}");
        }
    }
}