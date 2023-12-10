
namespace SquaredNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Square(number));

            if (number == 1)
            {
                int[] nume = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n > 0)
                .ToArray();

                Console.WriteLine(String.Join(" ", nume));
            }
            
            if (number == 0)
            {
                string[] words = Console.ReadLine()
                    .Split()
                    .Where(x => x.Length % 2 == 0)
                    .ToArray();

                Console.WriteLine(String.Join(" ", words));
            }

            int[] jerry = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            int count = jerry.Length >= 3 ? 3 : jerry.Length;

            Console.WriteLine(count);

            var nums = new int[] { 10, 20, 30, 40, 50 };
            var nums2 = nums.Select(x => "num" + x / 2);
            Console.WriteLine(String.Join(", ", nums2));

            switch (number)
            {
                case 69:
                    Console.WriteLine(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Min());
                    break;
                case 70:
                    Console.WriteLine(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Max());
                    break;
                case 71:
                    Console.WriteLine(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Sum());
                    break;
                case 72:
                    Console.WriteLine(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Average());
                    break;
            }
        }

        static int Square(int ex) => ex * ex;
    }
}