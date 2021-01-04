using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                List<string> commands = command.Split().ToList();

                switch (commands[0])
                {
                    case "Add": numbers.Add(int.Parse(commands[1])); break;
                    case "Remove": numbers.Remove(int.Parse(commands[1])); break;
                    case "RemoveAt": numbers.RemoveAt(int.Parse(commands[1])); break;
                    case "Insert": numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1])); break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
