using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            resources.Add("shards", 0);
            resources.Add("fragments", 0);
            resources.Add("motes", 0);

            bool isObtained = resources.Any(r => r.Value >= 250);

            while (isObtained == false)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 1; i < input.Length; i += 2)
                {
                    if (resources.ContainsKey(input[i].ToLower()))
                    {
                        resources[input[i].ToLower()] += int.Parse(input[i - 1]);

                        isObtained = resources.Any(r => r.Value >= 250);
                        if (isObtained == true)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(input[i].ToLower()))
                        {
                            junk[input[i].ToLower()] = 0;
                        }

                        junk[input[i].ToLower()] += int.Parse(input[i - 1]);
                    }
                }

                //isObtained = resources.Any(r => r.Value >= 250);
            }

            foreach (var r in resources)
            {
                if (r.Value >= 250)
                {
                    if (r.Key == "shards")
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                    }
                    else if (r.Key == "fragments")
                    {
                        Console.WriteLine("Valanyr obtained!");
                    }
                    else
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                    }

                    resources[r.Key] -= 250;
                    break;
                }
            }

            resources = resources.
                OrderByDescending(r => r.Value).
                ThenBy(r => r.Key).
                ToDictionary(r => r.Key, r => r.Value);
            junk = junk.OrderBy(j => j.Key).ToDictionary(j => j.Key, j => j.Value);

            foreach (var r in resources)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }

            foreach (var j in junk)
            {
                Console.WriteLine($"{j.Key}: {j.Value}");
            }
        }
    }
}
