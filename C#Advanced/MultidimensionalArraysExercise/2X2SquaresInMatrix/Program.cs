using System;
using System.Linq;

namespace _2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] array = new char[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                char[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

                for (int j = 0; j < sizes[1]; j++)
                {
                    array[i, j] = arr[j];
                }
            }

            int count = 0;

            for (int i = 0; i < sizes[0] - 1; i++)
            {
                for (int j = 0; j < sizes[1] - 1; j++)
                {
                    if (array[i,j] == array[i+1,j] && array[i, j] == array[i, j + 1] && array[i, j] == array[i + 1, j + 1] &&
                        array[i, j + 1] == array[i + 1, j] && array[i, j + 1] == array[i + 1, j + 1] &&
                        array[i + 1, j] == array[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
