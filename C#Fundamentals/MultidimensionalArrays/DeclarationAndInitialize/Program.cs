using System;

namespace DeclarationAndInitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 }, { 15, 16 } };

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            Console.WriteLine(arr.Rank);  // number of dimensions

            Console.WriteLine(arr[2, 0]);   //5
            arr[2, 0] = 77;

            // print the array on the console
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }

            // array with 3 dimensions
            int[,,] array3;
            array3 = new int[3, 3, 2] { { { 1, 1 }, { 1, 1 }, { 1, 1 } }, { { 2, 2 }, { 2, 2 }, { 2, 2 } }, { { 3, 3 }, { 3, 3 }, { 3, 3 } } };
            Console.WriteLine();

            // print
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                Console.Write("| ");

                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    for (int k = 0; k < array3.GetLength(2); k++)
                    {
                        Console.Write(array3[i,j,k] + " ");
                    }

                    Console.Write("| ");
                }

                Console.WriteLine();
            }



            // read a matrix from the console
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix[{i}, {j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
