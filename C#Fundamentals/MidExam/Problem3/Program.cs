using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> desk = new List<string>();
            string input = Console.ReadLine();

            while (input != "Ready")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Add")
                {
                    int count = cards.Where(n => n == command[1]).Count();

                    if (count == 0)
                    {
                        Console.WriteLine("Card not found.");
                    }
                    else
                    {
                        desk.Add(command[1]);
                    }
                }
                else if (command[0] == "Insert")
                {         
                    int count = cards.Where(n => n == command[1]).Count();

                    if (count == 0 || !(int.Parse(command[2]) >= 0 && int.Parse(command[2]) < desk.Count))
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        desk.Insert(int.Parse(command[2]), command[1]);
                    }
                }
                else if (command[0] == "Remove")
                {
                    int count = desk.Where(n => n == command[1]).Count();

                    if (count == 0)
                    {
                        Console.WriteLine("Card not found.");
                    }

                    desk.Remove(command[1]);
                }
                else if (command[0] == "Swap")
                {                    
                    int index1 = desk.IndexOf(command[1]);
                    int index2 = desk.IndexOf(command[2]);

                    desk[index1] = command[2];                    
                    desk[index2] = command[1];                    
                }
                else
                {
                    desk.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', desk));
        }
    }
}
