using System;
using System.Linq;
using System.Collections.Generic;

namespace SnakeMoves
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

            string snake = Console.ReadLine();
            Queue<char> queue = new Queue<char>(snake);

            for (int i = 0; i < sizes[0]; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < sizes[1]; j++)
                    {
                        array[i, j] = queue.Peek();
                        queue.Enqueue(queue.Dequeue());
                    }
                }
                else
                {
                    for (int j = sizes[1] - 1; j >= 0; j--)
                    {
                        array[i, j] = queue.Peek();
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }

            for (int i = 0; i < sizes[0]; i++)
            {
                for (int j = 0; j < sizes[1]; j++)
                {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
