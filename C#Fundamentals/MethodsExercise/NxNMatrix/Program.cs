using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintRow(n);
                Console.WriteLine();
            }
        }

        static void PrintRow(int r)
        {
            for (int i = 0; i < r; i++)
            {
                Console.Write($"{r} ");
            }
        }
    }
}
