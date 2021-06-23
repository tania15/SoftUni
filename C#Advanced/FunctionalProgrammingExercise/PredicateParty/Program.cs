using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<List<string>, string, string, List<string>> doubleNames = (names, command, condition) =>
            {
                List<string> doubleNames = new List<string>();

                foreach (string n in names)
                {
                    doubleNames.Add(n);

                    if ((command == "StartsWith" && n.StartsWith(condition)) || 
                    (command == "EndsWith" && n.EndsWith(condition)) || 
                    (command == "Length" && n.Length == int.Parse(condition)))
                    {                        
                        doubleNames.Add(n);
                    }
                }

                return doubleNames;
            };

            Func<List<string>, string, string, List<string>> removeNames = (names, command, condition) =>
            {
                List<string> removedNames = new List<string>(names);

                foreach (string n in names)
                {
                    if ((command == "StartsWith" && n.StartsWith(condition)) ||
                    (command == "EndsWith" && n.EndsWith(condition)) ||
                    (command == "Length" && n.Length == int.Parse(condition)))
                    {
                        removedNames.Remove(n);
                    }
                }

                return removedNames;
            };

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Double":
                        names = doubleNames(names, command[1], command[2]);
                        break;
                    case "Remove":
                        names = removeNames(names, command[1], command[2]);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
