namespace AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(", ").Select(double.Parse).Select(n => n * 1.2).ToArray();
            foreach(double d in nums)
                Console.WriteLine($"{d:F2}");
        }
    }
}