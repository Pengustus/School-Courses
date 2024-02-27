namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<int, int, int> func = (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                    return -1;

                if (x % 2 != 0 && y % 2 == 0)
                    return 1;

                return x.CompareTo(y);
            };

            nums.Sort((x,y) => func(x,y));
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}