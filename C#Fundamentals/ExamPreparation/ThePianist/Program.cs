using System;
using System.Linq;
using System.Collections.Generic;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                pieces.Add(data[0], new string[] { data[1], data[2] });
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split('|', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                        if (pieces.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} is already in the collection!");
                        }
                        else
                        {
                            pieces.Add(command[1], new string[] { command[2], command[3] });

                            Console.WriteLine($"{command[1]} by {command[2]} in {command[3]} added to the collection!");
                        }

                        break;
                    case "Remove":
                        if (pieces.ContainsKey(command[1]))
                        {
                            pieces.Remove(command[1]);
                            Console.WriteLine($"Successfully removed {command[1]}!");                            
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                        }

                        break;
                    case "ChangeKey":
                        if (pieces.ContainsKey(command[1]))
                        {
                            pieces[command[1]][1] = command[2];
                            Console.WriteLine($"Changed the key of {command[1]} to {command[2]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                        }

                        break;
                            default:
                        break;
                }

                input = Console.ReadLine();
            }

            pieces = pieces
                .OrderBy(p => p.Key)
                .ThenBy(p => p.Value[0]).
                ToDictionary(k => k.Key, v => v.Value);

            foreach (var p in pieces)
            {
                Console.WriteLine($"{p.Key} -> Composer: {p.Value[0]}, Key: {p.Value[1]}");
            }
        }
    }
}
