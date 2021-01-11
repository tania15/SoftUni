using System;
using System.Linq;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {                
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                
                resources[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var r in resources)
            {
                Console.WriteLine($"{r.Key} -> {r.Value}");
            }
        }
    }
}
