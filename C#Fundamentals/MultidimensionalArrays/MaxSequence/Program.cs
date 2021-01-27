using System;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the maximum sequence of a rectangular matrix with strings. Sequence is when the elements are on the same row, column or diagonal.

            string[,] matrix =
            {
                { "ha", "fi", "ho", "hi" },
                { "fo", "ha", "hi", "xx" },
                { "xx", "ho", "ha", "xx" }
            };

            int maxSequence = 0;
            int count = 1;
            string bestElement = string.Empty;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int n = 1;

                    while (col + n < matrix.GetLength(1) && matrix[row, col] == matrix[row, col + n])
                    {
                        n++;
                        count++;                        
                    }

                    if (count > maxSequence)
                    {
                        maxSequence = count;
                        bestElement = matrix[row, col];
                        n = 1;
                        count = 1;
                    }

                    while (row + n < matrix.GetLength(0) && matrix[row, col] == matrix[row + 1, col])
                    {
                        n++;
                        count++;
                    }

                    if (count > maxSequence)
                    {
                        maxSequence = count;
                        bestElement = matrix[row, col];
                        n = 1;
                        count = 1;
                    }

                    while (row + n < matrix.GetLength(0) && col + n < matrix.GetLength(1) && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        n++;
                        count++;
                    }

                    if (count > maxSequence)
                    {
                        maxSequence = count;
                        bestElement = matrix[row, col];
                        n = 1;
                        count = 1;
                    }
                }
            }

            Console.WriteLine(bestElement);
            Console.WriteLine(maxSequence);
        }
    }
}
