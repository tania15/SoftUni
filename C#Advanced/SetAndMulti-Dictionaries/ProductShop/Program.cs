using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();

            while (input.ToLower() != "revision")
            {
                string[] product = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (!shops.ContainsKey(product[0]))                
                {
                    shops.Add(product[0], new Dictionary<string, double>());                    
                }

                shops[product[0]].Add(product[1], double.Parse(product[2]));

                input = Console.ReadLine();
            }

            foreach (var p in shops)
            {
                Console.WriteLine($"{p.Key}->");

                foreach (var v in p.Value)
                {
                    Console.WriteLine($"Product: {v.Key}, Price: {v.Value}");
                }
            }
        }
    }
}
