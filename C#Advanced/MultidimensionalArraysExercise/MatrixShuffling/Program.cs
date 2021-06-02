using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] array = new string[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);                    

                for (int j = 0; j < sizes[1]; j++)
                {
                    array[i, j] = arr[j];
                }
            }

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length != 5 || 
                    int.Parse(command[1]) > sizes[0] || int.Parse(command[1]) < 0 ||
                    int.Parse(command[2]) > sizes[1] || int.Parse(command[2]) < 0 ||
                    int.Parse(command[3]) > sizes[0] || int.Parse(command[3]) < 0 ||
                    int.Parse(command[4]) > sizes[1] || int.Parse(command[4]) < 0)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;                    
                }

                string temp = array[int.Parse(command[1]), int.Parse(command[2])];
                array[int.Parse(command[1]), int.Parse(command[2])] = array[int.Parse(command[3]), int.Parse(command[4])];
                array[int.Parse(command[3]), int.Parse(command[4])] = temp;

                for (int i = 0; i < sizes[0]; i++)
                {
                    for (int j = 0; j < sizes[1]; j++)
                    {
                        Console.Write(array[i,j] + " ");
                    }

                    Console.WriteLine();
                }

                input = Console.ReadLine();
            }
        }
    }
}
