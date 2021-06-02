﻿using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int i = 0; i < size; i++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = array[j];

                    if (i == j)
                    {
                        sumPrimaryDiagonal += matrix[i, j];
                    }

                    if (i + j == size - 1)
                    {
                        sumSecondaryDiagonal += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
        }
    }
}
