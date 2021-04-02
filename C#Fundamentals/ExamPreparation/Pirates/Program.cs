using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();
            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] city = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (cities.ContainsKey(city[0]))
                {
                    cities[city[0]][0] += int.Parse(city[1]);
                    cities[city[0]][1] += int.Parse(city[2]);
                }
                else
                {
                    cities.Add(city[0], new int[] { int.Parse(city[1]), int.Parse(city[2])});
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] attack = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (attack[0] == "Plunder")
                {
                    if (cities.ContainsKey(attack[1]))
                    {
                        cities[attack[1]][0] -= int.Parse(attack[2]);
                        cities[attack[1]][1] -= int.Parse(attack[3]);

                        Console.WriteLine($"{attack[1]} plundered! {attack[3]} gold stolen, {attack[2]} citizens killed.");

                        if (cities[attack[1]][0] == 0 || cities[attack[1]][1] == 0)
                        {
                            cities.Remove(attack[1]);
                            Console.WriteLine($"{attack[1]} has been wiped off the map!");
                        }
                    }                    
                }
                else
                {
                    if (int.Parse(attack[2]) <= 0)
                    {                        
                        Console.WriteLine("Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        if (cities.ContainsKey(attack[1]))
                        {
                            cities[attack[1]][1] += int.Parse(attack[2]);
                            Console.WriteLine($"{attack[2]} gold added to the city treasury. {attack[1]} now has {cities[attack[1]][1]} gold.");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            cities = cities.OrderByDescending(c => c.Value[1]).ThenBy(c => c.Key).ToDictionary(c => c.Key, p => p.Value);
            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

            foreach (var c in cities)
            {
                Console.WriteLine($"{c.Key} -> Population: {c.Value[0]} citizens, Gold: {c.Value[1]} kg");
            }
        }
    }
}
