namespace YogaClass
{
    internal class YogaClass
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            int people = int.Parse(Console.ReadLine());

            decimal mat = prices[0];
            decimal ball = prices[1];
            decimal blocks = prices[2];

            decimal totalMats = people * mat * 1.2m;
            int freeBalls = people / 5;

            decimal sum = people * (ball - freeBalls + blocks * 2) + totalMats;

            Console.WriteLine($"{sum:F2}$ needed for equipment.");
        }
    }
}