using System;
using System.Linq;
using System.Collections.Generic;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] array = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    array[i, j] = 0;
                }
            }

            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                int[] index = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (index[0] < dimensions[0] && index[0] >= 0 && index[1] < dimensions[1] && index[1] >= 0)
                {
                    //array[index[0], index[1]]++;

                    for (int i = 0; i < dimensions[1]; i++)
                    {
                        array[index[0], i]++;
                    }

                    for (int i = 0; i < dimensions[0]; i++)
                    {
                        if (index[0] != i)
                        {
                            array[i, index[1]]++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
