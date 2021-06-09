using System;
using System.Linq;
using System.Collections.Generic;

namespace TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> following = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input.ToLower() != "statistics")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Contains("joined"))
                {
                    if (!followers.ContainsKey(tokens[0]))
                    {
                        followers.Add(tokens[0], new List<string>());
                        following.Add(tokens[0], new List<string>());
                    }
                }
                else
                {
                    if (followers.ContainsKey(tokens[0]) && followers.ContainsKey(tokens[2]))
                    {
                        if (!followers[tokens[2]].Contains(tokens[0]) && !following[tokens[0]].Contains(tokens[2]) && tokens[0] != tokens[2])
                        {
                            followers[tokens[2]].Add(tokens[0]);
                            following[tokens[0]].Add(tokens[2]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");
            int count = 1;

            foreach (var f in followers.OrderByDescending(f => f.Value.Count).ThenBy(f => following[f.Key].Count))
            {
                Console.WriteLine($"{count}. {f.Key} : {f.Value.Count} followers, {following[f.Key].Count} following");

                if (count == 1)
                {
                    foreach (string l in f.Value.OrderBy(l => l))
                    {
                        Console.WriteLine($"*  {l}");
                    }
                }

                count++;
            }
        }
    }
}
