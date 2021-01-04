using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationAdvanced
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
            bool isChanged = false;

            while (command.ToLower() != "end")
            {
                List<string> commands = command.Split().ToList();

                switch (commands[0].ToLower())
                {
                    case "add":
                        numbers.Add(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "remove":
                        numbers.Remove(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "removeat":
                        numbers.RemoveAt(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "contains":
                        Console.WriteLine(numbers.Contains(int.Parse(commands[1])) == true ? "Yes" : "No such number");
                        break;
                    case "printeven":
                        Console.WriteLine(string.Join(' ', numbers.Where(n => n % 2 == 0)));
                        break;
                    case "printodd":
                        Console.WriteLine(string.Join(' ', numbers.Where(n => n % 2 == 1)));
                        break;
                    case "getsum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "filter":
                        if (commands[1] == ">")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n > int.Parse(commands[2]))));
                        }
                        else if (commands[1] == "<")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n < int.Parse(commands[2]))));
                        }
                        else if (commands[1] == ">=")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n >= int.Parse(commands[2]))));
                        }
                        else
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n <= int.Parse(commands[2]))));
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            if (isChanged == true)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }

        }
    }
}
