using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];

            for (int i = 0; i < dimentions[0]; i++)
            {
                int[] col = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < col.Length; j++)
                {
                    matrix[i, j] = col[j];
                }
            }

            Console.WriteLine(dimentions[0]);
            Console.WriteLine(dimentions[1]);

            int sum = 0;

            foreach (int m in matrix)
            {
                sum += m;
            }

            Console.WriteLine(sum);
        }
    }
}
