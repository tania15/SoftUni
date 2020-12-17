using System;

namespace _14.NestedLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int t = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (t > n)
                    {
                        break;
                    }

                    Console.Write($"{t} ");
                    t++;
                }

                Console.WriteLine();
            }
        }
    }
}
