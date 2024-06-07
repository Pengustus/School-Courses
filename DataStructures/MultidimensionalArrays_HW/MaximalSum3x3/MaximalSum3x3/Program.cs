namespace MaximalSum3x3
{
    internal class Program
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

            int topG = 0;
            int topRow = 0;
            int topCol = 0;

            for (int row = 0; row < size[0] - 2; row++)
            {
                for (int col = 0; col < size[1] - 2; col++)
                {
                    int g = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1]
                        + matrix[row, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 2] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col + 1];              

                    if (g > topG)
                    {
                        topRow = row;
                        topCol = col;
                        topG = g;
                    }
                }
            }

            Console.WriteLine($"Sum = {topG}");
            Console.WriteLine($"{matrix[topRow, topCol]} {matrix[topRow, topCol + 1]} {matrix[topRow, topCol + 2]}");
            Console.WriteLine($"{matrix[topRow + 1, topCol]} {matrix[topRow + 1, topCol + 1]} {matrix[topRow + 1, topCol + 2]}");
            Console.WriteLine($"{matrix[topRow + 2, topCol]} {matrix[topRow + 2, topCol + 1]} {matrix[topRow + 2, topCol + 2]}");
        }   
    }
}