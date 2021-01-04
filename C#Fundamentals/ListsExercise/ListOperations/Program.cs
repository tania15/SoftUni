using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input.Split();

                switch (command[0].ToLower())
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "insert":
                        if (int.Parse(command[2]) < numbers.Count)
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "remove":
                        if (int.Parse(command[1]) < numbers.Count)
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "shift":
                        int count = 0;
                        if (command[1].ToLower() == "left")
                        {
                            while (count < int.Parse(command[2]))
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                                count++;
                            }
                        }

                        if (command[1].ToLower() == "right")
                        {
                            while (count < int.Parse(command[2]))
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                                count++;
                            }
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
