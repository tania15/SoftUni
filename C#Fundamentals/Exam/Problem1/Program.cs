using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Translate":
                        text = text.Replace(command[1], command[2]);
                        Console.WriteLine(text);
                        break;
                    case "Includes":
                        Console.WriteLine(text.Contains(command[1]));
                        break;
                    case "Start":
                        Console.WriteLine(text.StartsWith(command[1]));
                        break;
                    case "Lowercase":
                        text = text.ToLower();
                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        Console.WriteLine(text.LastIndexOf(command[1]));
                        break;
                    case "Remove":
                        text = text.Remove(int.Parse(command[1]), int.Parse(command[2]));
                        Console.WriteLine(text);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
