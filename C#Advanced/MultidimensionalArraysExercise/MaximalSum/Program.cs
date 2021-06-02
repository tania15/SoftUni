using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] array = new int[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < sizes[1]; j++)
                {
                    array[i, j] = arr[j];
                }
            }

            int maxSum = int.MinValue;
            int row = 0;
            int col = 0;

            for (int i = 0; i < sizes[0] - 2; i++)
            {
                for (int j = 0; j < sizes[1] - 2; j++)
                {
                    if (array[i, j] + array[i, j + 1] + array[i, j + 2] + 
                        array[i + 1, j] + array[i + 1, j + 1] + array[i + 1, j + 2] +
                        array[i + 2, j] + array[i + 2, j + 1] + array[i + 2, j + 2] 
                        > maxSum)
                    {
                        maxSum = array[i, j] + array[i, j + 1] + array[i, j + 2] +
                        array[i + 1, j] + array[i + 1, j + 1] + array[i + 1, j + 2] +
                        array[i + 2, j] + array[i + 2, j + 1] + array[i + 2, j + 2];
                        row = i;
                        col = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
