using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] company = input.Split(" -> ");

                if (data.ContainsKey(company[0]))
                {
                    if (!data[company[0]].Any(x => x == company[1]))
                    {
                        data[company[0]].Add(company[1]);
                    }
                }
                else
                {
                    data[company[0]] = new List<string>() { company[1] };
                }

                input = Console.ReadLine();
            }

            //data = data.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);

            foreach (var d in data.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{d.Key}");

                foreach (var i in d.Value)
                {
                    Console.WriteLine($"-- {i}");
                }
            }
        }
    }
}
