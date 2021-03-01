using System;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string input = Console.ReadLine();

            while (input != "Report")
            {
                string[] command = input
                    .Split()
                    .ToArray();

                if (command[0] == "Blacklist")
                {
                    bool isFind = false;

                    for (int i = 0; i < names.Length; i++)
                    {                        
                        if (names[i] == command[1])
                        {
                            Console.WriteLine($"{command[1]} was blacklisted.");
                            names[i] = "Blacklisted";                            
                            isFind = true;
                            //break;
                        }
                    }

                    if (isFind == false)
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    if (!(names[int.Parse(command[1])] == "Lost" || names[int.Parse(command[1])] == "Blacklisted"))
                    {
                        Console.WriteLine($"{names[int.Parse(command[1])]} was lost due to an error.");
                        names[int.Parse(command[1])] = "Lost";
                    }
                }
                else
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < names.Length)
                    {
                        string currentUser = names[int.Parse(command[1])];
                        names[int.Parse(command[1])] = command[2];
                        Console.WriteLine($"{currentUser} changed his username to {names[int.Parse(command[1])]}.");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {names.Where(n => n == "Blacklisted").Count()}");
            Console.WriteLine($"Lost names: {names.Where(n => n == "Lost").Count()}");
            Console.WriteLine(string.Join(' ', names));
        }
        
    }
}
