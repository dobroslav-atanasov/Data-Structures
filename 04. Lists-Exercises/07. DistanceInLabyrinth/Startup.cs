namespace _07._DistanceInLabyrinth
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            int startRow = 0;
            int startCol = 0;
            int xCell = -1;
            int position = -2;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] matrixRow = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrixRow.Length; j++)
                {
                    if (matrixRow[j] == '*')
                    {
                        startRow = i;
                        startCol = j;
                        matrix[startRow, startCol] = position;
                    }
                    else
                    {
                        matrix[i, j] = matrixRow[j] == 'x' ? xCell : 0;
                    }
                }
            }

            Queue<Cell> queue = new Queue<Cell>();
            queue.Enqueue(new Cell(startRow, startCol));
            matrix[startRow, startCol] = 0;

            while (queue.Count > 0)
            {
                Cell cell = queue.Dequeue();

                if (cell.Row - 1 >= 0 && matrix[cell.Row - 1, cell.Col] == 0)
                {
                    queue.Enqueue(new Cell(cell.Row - 1, cell.Col));
                    matrix[cell.Row - 1, cell.Col] += matrix[cell.Row, cell.Col] + 1;
                }
                if (cell.Col + 1 < size && matrix[cell.Row, cell.Col + 1] == 0)
                {
                    queue.Enqueue(new Cell(cell.Row, cell.Col + 1));
                    matrix[cell.Row, cell.Col + 1] += matrix[cell.Row, cell.Col] + 1;
                }
                if (cell.Row + 1 < size && matrix[cell.Row + 1, cell.Col] == 0)
                {
                    queue.Enqueue(new Cell(cell.Row + 1, cell.Col));
                    matrix[cell.Row + 1, cell.Col] += matrix[cell.Row, cell.Col] + 1;
                }
                if (cell.Col - 1 >= 0 && matrix[cell.Row, cell.Col - 1] == 0)
                {
                    queue.Enqueue(new Cell(cell.Row, cell.Col - 1));
                    matrix[cell.Row, cell.Col - 1] += matrix[cell.Row, cell.Col] + 1;
                }
            }

            matrix[startRow, startCol] = position;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == position)
                    {
                        Console.Write("*");
                    }
                    else if (matrix[row, col] == xCell)
                    {
                        Console.Write("x");
                    }
                    else if (matrix[row, col] == 0)
                    {
                        Console.Write("u");
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}