namespace BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            int max = 0;

            for (int i = 0; i < students; i++)
            {
                int student = int.Parse(Console.ReadLine());

                if (student > max)
                {
                    max = student;
                }
            }

            double maxbonus = (max / lectures) * (5 + bonus);
            double maxbonus1 = Math.Ceiling(maxbonus);

            Console.WriteLine($"Max Bonus: {maxbonus1}.");
            Console.WriteLine($"The student has attended {max} lectures.");
        }
    }
}