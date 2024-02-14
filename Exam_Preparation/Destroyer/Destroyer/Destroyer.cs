namespace Destroyer
{
    internal class Destroyer
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input?.ToLower() == "cease fire!")
                {
                    int destroyed = 0;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (matrix[row, col] <= 0)
                            {
                                destroyed++;
                            }
                        }
                    }

                    double percentDestroyed = (double)destroyed / (size[0] * size[1]) * 100;

                    Console.WriteLine($"Destroyed bunkers: {destroyed}");
                    Console.WriteLine($"Damage done: {percentDestroyed:F1}%");

                    return;
                }

                string[] data = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int vow = int.Parse(data[0]);
                int vol = int.Parse(data[1]);
                int strength = char.Parse(data[2]);
                int adjacent = (int)Math.Ceiling((double)strength / 2);

                matrix[vow, vol] -= strength;

                if (vow - 1 >= 0 && vol - 1 >= 0)
                {
                    matrix[vow - 1, vol - 1] -= adjacent;
                }

                if (vow - 1 >= 0 && vol + 1 < size[1])
                {
                    matrix[vow - 1, vol + 1] -= adjacent;
                }

                if (vow - 1 >= 0)
                {
                    matrix[vow - 1, vol] -= adjacent;
                }

                if (vol - 1 >= 0)
                {
                    matrix[vow, vol - 1] -= adjacent;
                }

                if (vol + 1 < size[1])
                {
                    matrix[vow, vol + 1] -= adjacent;
                }

                if (vow + 1 < size[0] && vol - 1 >= 0)
                {
                    matrix[vow + 1, vol - 1] -= adjacent;
                }

                if (vow + 1 < size[0])
                {
                    matrix[vow + 1, vol] -= adjacent;
                }

                if (vow + 1 < size[0] && vol + 1 < size[1])
                {
                    matrix[vow + 1, vol + 1] -= adjacent;
                }
            }
        }
    }
}