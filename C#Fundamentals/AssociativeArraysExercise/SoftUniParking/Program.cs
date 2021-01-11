using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "register")
                {
                    if (!parking.ContainsKey(command[1]))
                    {
                        parking[command[1]] = command[2];
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                }
                else
                {
                    if (parking.ContainsKey(command[1]))
                    {
                        parking.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }

            foreach (var p in parking)
            {
                Console.WriteLine($"{p.Key} => {p.Value}");
            }
        }
    }
}
