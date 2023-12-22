namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] slots = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < slots.Length; i++)
            {
                while (slots[i] < 4 && people > 0)
                {
                    slots[i]++;
                    people--;
                }
            }

            if (people == 0 && slots[slots.Length - 1] != 4)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine($"{String.Join(" ", slots)}");
            }
            else if (slots[slots.Length - 1] == 4 && people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine($"{String.Join(" ", slots)}");
            }
            else
            {
                Console.WriteLine($"{String.Join(" ", slots)}");
            }
        }
    }
}