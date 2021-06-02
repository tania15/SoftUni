using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] indexes = bombs[i]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int indexRow = indexes[0];
                int indexCol = indexes[1];

                //matrix[indexRow, indexCol] = 0;

                if (indexRow - 1 >= 0 && indexCol - 1 >= 0 && matrix[indexRow - 1, indexCol - 1] > 0)
                {
                    matrix[indexRow - 1, indexCol - 1] -= matrix[indexRow, indexCol];
                }

                if (indexRow - 1 >= 0 && matrix[indexRow - 1, indexCol] > 0)
                {
                    matrix[indexRow - 1, indexCol] -= matrix[indexRow, indexCol];
                }

                if (indexRow - 1 >= 0 && indexCol + 1 < matrix.GetLength(1) && matrix[indexRow - 1, indexCol + 1] > 0)
                {
                    matrix[indexRow - 1, indexCol + 1] -= matrix[indexRow, indexCol];
                }

                if (indexCol - 1 >= 0 && matrix[indexRow, indexCol - 1] > 0)
                {
                    matrix[indexRow, indexCol - 1] -= matrix[indexRow, indexCol];
                }

                if (indexCol + 1 < matrix.GetLength(1) && matrix[indexRow, indexCol + 1] > 0)
                {
                    matrix[indexRow, indexCol + 1] -= matrix[indexRow, indexCol];
                }

                if (indexRow + 1 < matrix.GetLength(0) && indexCol - 1 >= 0 && matrix[indexRow + 1, indexCol - 1] > 0)
                {
                    matrix[indexRow + 1, indexCol - 1] -= matrix[indexRow, indexCol];
                }

                if (indexRow + 1 < matrix.GetLength(0) && matrix[indexRow + 1, indexCol] > 0)
                {
                    matrix[indexRow + 1, indexCol] -= matrix[indexRow, indexCol];
                }

                if (indexRow + 1 < matrix.GetLength(0) && indexCol + 1 < matrix.GetLength(1) && matrix[indexRow + 1, indexCol + 1] > 0)
                {
                    matrix[indexRow + 1, indexCol + 1] -= matrix[indexRow, indexCol];
                }

                matrix[indexRow, indexCol] = 0;
            }

            int sum = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
