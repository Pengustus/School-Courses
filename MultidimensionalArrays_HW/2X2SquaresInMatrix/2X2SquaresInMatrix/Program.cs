using System.ComponentModel.DataAnnotations;
using System.Net.Security;

namespace _2X2SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int count = 0;

            for (int row = 0; row < sizes[0] - 1; row++)
            {
                for (int col = 0;  col < sizes[1] - 1; col++)
                {
                    if (Check(row, col, matrix))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        static bool Check(int row, int col, char[,] matrix)
        {
            if (matrix[row, col] == matrix[row + 1, col] &&
                matrix[row, col] == matrix[row, col + 1] &&
                matrix[row, col] == matrix[row + 1, col + 1])
            {
                return true;
            }

            return false;
        }
    }
}