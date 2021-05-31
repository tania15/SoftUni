using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int maxSum = int.MinValue;
            int col = 0;
            int row = 0;

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] arr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            for (int i = 0; i < sizes[0] - 1; i++)
            {
                for (int j = 0; j < sizes[1] - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        col = j;
                        row = i;
                    }
                }
            }

            Console.WriteLine(matrix[row, col] + " " + matrix[row, col + 1]);
            Console.WriteLine(matrix[row + 1, col] + " " + matrix[row + 1, col + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
