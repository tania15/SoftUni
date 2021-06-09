using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe= new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];
                string[] clothes = tokens[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 1);
                    }
                    else
                    {
                        wardrobe[color][clothes[j]]++;
                    }
                }                
            }

            string[] clothingForFind = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var w in wardrobe)
            {
                Console.WriteLine($"{w.Key} clothes:");

                foreach (var c in w.Value)
                {                    
                    if (w.Key == clothingForFind[0] && c.Key == clothingForFind[1])
                    {
                        Console.WriteLine($"* {c.Key} - {c.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {c.Key} - {c.Value}");
                    }
                }
            }
        }
    }
}
