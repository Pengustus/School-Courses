namespace BestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            var bestWords = input.Where(word => word.Contains("est", StringComparison.OrdinalIgnoreCase))
                                 .Select(word => word.ToUpper())
                                 .ToArray();

            string first = bestWords.FirstOrDefault(word => word.Contains("B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"First best word: {first}");

            string second = bestWords.LastOrDefault(word => word.Contains("B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Last best word: {second}");
        }
    }
}