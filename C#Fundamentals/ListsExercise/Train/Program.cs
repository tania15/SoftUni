using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int capacityOfWagon = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> commands = input
                    .Split()
                    .ToList();

                if (commands[0] == "Add")
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(commands[0]) <= capacityOfWagon)
                        {
                            wagons[i] += int.Parse(commands[0]);
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
