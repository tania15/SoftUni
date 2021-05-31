using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] jagged = new int[size][];

            for (int i = 0; i < size; i++)
            {
                jagged[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0].ToLower() == "add")
                {
                    if (int.Parse(command[1]) < size && int.Parse(command[1]) >= 0 && int.Parse(command[2]) < size && int.Parse(command[2]) >= 0)
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    if (int.Parse(command[1]) < size && int.Parse(command[1]) >= 0 && int.Parse(command[2]) < size && int.Parse(command[2]) >= 0)
                    {
                        jagged[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (int[] j in jagged)
            {
                Console.WriteLine(string.Join(' ', j));
            }
        }
    }
}
