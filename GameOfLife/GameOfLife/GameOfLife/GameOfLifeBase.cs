using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameOfLifeBase
    {
        internal StringBuilder stringBuilder;

        public int X { get; set; }
        public int Y { get; set; }

        public int[,] CurrentCellGeneration { get; set; }

        public int[,] NextCellGeneration { get; set; }

        public GameOfLifeBase(int x, int y)
        {
            X = x;
            Y = y;

            CurrentCellGeneration = new int[X, Y];
            NextCellGeneration = new int[X, Y];
        }

        public string Draw(int boardSize, int windowWidth)
        {
            string[,] sceneBuffer = new string[boardSize, windowWidth / 2];

            for (int row = 0; row < sceneBuffer.GetLength(0); row++)
            {
                for (int col = 0; col < sceneBuffer.GetLength(1); col++)
                {
                    if (CurrentCellGeneration[row, col] == 1)
                    {
                        sceneBuffer[row, col] = "□ ";
                    }
                    else
                    {
                        sceneBuffer[row, col] = "  ";
                    }
                }
            }

            stringBuilder = new StringBuilder();

            for (int row = 0; row < sceneBuffer.GetLength(0); row++)
            {
                for (int col = 0; col < sceneBuffer.GetLength(1); col++)
                {
                    stringBuilder.Append(sceneBuffer[row, col]);
                }

                stringBuilder.AppendLine();
            }

            DrawMenuPanel(windowWidth);

            return stringBuilder.ToString().TrimEnd();
        }

        public virtual void DrawMenuPanel(int windowWidth)
        {
            stringBuilder.AppendLine(new String('=', windowWidth));
        }

        public void SpawnNextGeneration()
        {
            for (int row = 0; row < NextCellGeneration.GetLength(0); row++)
            {
                for (int col = 0; col < NextCellGeneration.GetLength(1); col++)
                {
                    int liveNeighbors = CalculateLiveNeighbors(row, col);

                    if (CurrentCellGeneration[row, col] == 1 && liveNeighbors < 2)
                    {
                        NextCellGeneration[row, col] = 0;
                    }

                    else if (CurrentCellGeneration[row, col] == 1 && liveNeighbors > 3)
                    {
                        NextCellGeneration[row, col] = 0;
                    }

                    else if (CurrentCellGeneration[row, col] == 1 && liveNeighbors == 3)
                    {
                        NextCellGeneration[row, col] = 1;
                    }

                    else
                    {
                        NextCellGeneration[row, col] = CurrentCellGeneration[row, col];
                    }
                }
            }

            TransferNextGenerations();
        }

        private void TransferNextGenerations()
        {
            for (int row = 0; row < CurrentCellGeneration.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentCellGeneration.GetLength(1); col++)
                {
                    CurrentCellGeneration[row, col] = NextCellGeneration[row, col];
                }
            }
        }

        private int CalculateLiveNeighbors(int cellRow, int cellCol)
        {
            int liveNeighbors = 0;

            for (int neighborCellRow = -1; neighborCellRow <= -1; neighborCellRow++)
            {
                for (int neighborCellCol = -1; neighborCellCol <= -1; neighborCellCol++)
                {
                    if (IsOutOfBoundariesOrSameCell(cellRow, cellCol, neighborCellRow, neighborCellCol))
                    {
                        continue;
                    }

                    liveNeighbors += CurrentCellGeneration[cellRow + neighborCellRow, cellCol + neighborCellCol];
                }
            }

            return liveNeighbors;
        }

        private bool IsOutOfBoundariesOrSameCell(int cellRow, int cellCol, int neighborCellRow, int neighborCellCol)
        {
            if (cellRow + neighborCellRow< 0 || cellRow + neighborCellRow >= CurrentCellGeneration.GetLength(0))
            {
                return true;
            }

            if (cellCol + neighborCellCol < 0 || cellCol + neighborCellCol >= CurrentCellGeneration.GetLength(1))
            {
                return true;
            }

            if (cellRow + neighborCellRow == cellRow && cellCol + neighborCellCol == cellCol)
            {
                return true;
            }

            return false;
        }
    }
}
