using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> numbers = new Stack<int>(nums);

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0].ToLower() == "add")
                {
                    numbers.Push(int.Parse(command[1]));
                    numbers.Push(int.Parse(command[2]));
                }
                else
                {
                    if (numbers.Count < int.Parse(command[1]))
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        numbers.Pop();
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
