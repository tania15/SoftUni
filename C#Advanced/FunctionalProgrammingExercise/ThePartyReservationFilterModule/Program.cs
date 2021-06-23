using System;
using System.Linq;
using System.Collections.Generic;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> resultList = new List<string>(names);

            Func<List<string>, string, string, List<string>> add = (resultList, command, condition) =>
            {
                List<string> names = new List<string>();

                foreach (string n in resultList)
                {                    
                    if ((command == "Starts with" && !n.StartsWith(condition)) ||
                    (command == "Ends with" && !n.EndsWith(condition)) ||
                    (command == "Length" && n.Length != int.Parse(condition)) ||
                    (command == "Contains" && !n.Contains(condition)))
                    {
                        names.Add(n);
                    }
                }

                return names;
            };

            Func<List<string>, string, string, List<string>> removeNames = (resultList, command, condition) =>
            {                
                foreach (string n in names)
                {
                    if (((command == "Starts with" && n.StartsWith(condition)) ||
                    (command == "Ends with" && n.EndsWith(condition)) ||
                    (command == "Length" && n.Length == int.Parse(condition)) ||
                    (command == "Contains" && n.Contains(condition))) && 
                    !resultList.Contains(n))
                    {
                        resultList.Insert((names.IndexOf(n) < resultList.Count ? names.IndexOf(n) : resultList.Count), n);
                    }
                }

                return resultList;
            };

            string input = Console.ReadLine();

            while (input != "Print")
            {
                string[] command = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add filter":
                        resultList = add(resultList, command[1], command[2]);
                        break;
                    case "Remove filter":
                        resultList = removeNames(resultList, command[1], command[2]);
                        break;
                    
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
