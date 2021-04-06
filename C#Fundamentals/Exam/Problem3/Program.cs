using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Dictionary<string, int[]> users = new Dictionary<string, int[]>();


            while (input != "Statistics")
            {
                string[] command = input.Split('=', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                        if (!users.ContainsKey(command[1]))
                        {
                            users.Add(command[1], new int[] { int.Parse(command[2]), int.Parse(command[3]) });
                        }

                        break;
                    case "Message":
                        if (users.ContainsKey(command[1]) && users.ContainsKey(command[2]))
                        {
                            users[command[1]][0]++;
                            users[command[2]][1]++;

                            if (users[command[1]][0] >= capacity || (users[command[1]][0] + users[command[1]][1] >= capacity))
                            {
                                users.Remove(command[1]);
                                Console.WriteLine($"{command[1]} reached the capacity!");
                            }

                            if (users[command[2]][1] >= capacity || (users[command[2]][0] + users[command[2]][1] >= capacity))
                            {
                                users.Remove(command[2]);
                                Console.WriteLine($"{command[2]} reached the capacity!");
                            }
                        }

                        break;
                    case "Empty":
                        if (command[1] == "All")
                        {
                            users.Clear();
                        }
                        else
                        {
                            if (users.ContainsKey(command[1]))
                            {
                                users.Remove(command[1]);
                            }
                        }

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            users = users.OrderByDescending(v => v.Value[1]).ThenBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var u in users)
            {
                Console.WriteLine($"{u.Key} - {u.Value[0] + u.Value[1]}");
            }

        }
    }
}
