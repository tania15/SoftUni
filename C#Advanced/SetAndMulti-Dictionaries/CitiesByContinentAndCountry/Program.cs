using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!data.ContainsKey(tokens[0]))
                {
                    data.Add(tokens[0], new Dictionary<string, List<string>>());
                }

                if (!data[tokens[0]].ContainsKey(tokens[1]))
                {
                    data[tokens[0]].Add(tokens[1], new List<string>());
                    //data[tokens[0]][tokens[1]].Add(tokens[2]);
                }

                data[tokens[0]][tokens[1]].Add(tokens[2]);
            }

            foreach (var d in data)
            {
                Console.WriteLine($"{d.Key}:");

                foreach (var v in d.Value)
                {
                    Console.WriteLine($"{v.Key} -> {string.Join(", ", v.Value)}");
                }
            }
        }
    }
}
