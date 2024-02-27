namespace CustomMinFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, int> func = n => n.Min();
            Console.WriteLine(func(nums));
        }
    }
}