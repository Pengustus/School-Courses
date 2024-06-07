using System.Xml.Linq;

namespace SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string word = Console.ReadLine();

            char[,] matrix = new char[size[0], size[1]];
            int snakeCount = 0;
            
            for (int row = 0; row < size[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < size[1]; col++)
                    {
                        matrix[row, col] = word[snakeCount % word.Length];
                        snakeCount++;
                    }
                }
                else
                {
                    for (int col = size[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = word[snakeCount % word.Length];
                        snakeCount++;
                    }
                }
            }

            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}