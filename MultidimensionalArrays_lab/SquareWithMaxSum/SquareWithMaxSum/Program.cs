namespace SquareWithMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];
            int[,] subMatrix = new int[2, 2];
            int topSum = int.MinValue;

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = row[j];
                }                    
            }

            for (int row = 0; row < sizes[0] - 1; row++)
            {
                for (int col = 0; col < sizes[1] - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currentSum > topSum)
                    {
                        topSum = currentSum;
                        subMatrix[0, 0] = matrix[row, col];
                        subMatrix[0, 1] = matrix[row, col + 1];
                        subMatrix[1, 0] = matrix[row + 1, col];
                        subMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{subMatrix[0, 0]} {subMatrix[0, 1]}\n{subMatrix[1, 0]} {subMatrix[1, 1]}");
            Console.WriteLine(topSum);
        }
    }
}