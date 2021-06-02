using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[n][];

            for (int i = 0; i < n; i++)
            {
                double[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[i] = row;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] *= 2;
                        jaggedArray[i + 1][j] *= 2;
                    }

                }
                else
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] /= 2;

                        if (j < jaggedArray[i + 1].Length)
                        {
                            jaggedArray[i + 1][j] /= 2;
                        }
                    }

                    if (jaggedArray[i].Length < jaggedArray[i + 1].Length)
                    {
                        for (int j = jaggedArray[i].Length; j < jaggedArray[i + 1].Length; j++)
                        {
                            jaggedArray[i + 1][j] /= 2;
                        }
                    }

                }
            }

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= n || int.Parse(command[2]) < 0 || 
                    int.Parse(command[2]) >= jaggedArray[int.Parse(command[1])].Length)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (command[0].ToLower() == "add")
                {
                    jaggedArray[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                }
                else
                {
                    jaggedArray[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                }

                input = Console.ReadLine();
            }

            foreach (double[] a in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", a));
            }
        }
    }
}
