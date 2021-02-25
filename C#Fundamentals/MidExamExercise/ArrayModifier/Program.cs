using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "swap")
                {
                    int t = numbers[int.Parse(command[1])];
                    numbers[int.Parse(command[1])] = numbers[int.Parse(command[2])];
                    numbers[int.Parse(command[2])] = t;
                }
                else if (command[0] == "multiply")
                {
                    numbers[int.Parse(command[1])] *= numbers[int.Parse(command[2])];
                }
                else
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }

                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
