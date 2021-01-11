using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] product = input.Split();

                if (!products.ContainsKey(product[0]))
                {
                    products.Add(product[0], new List<double>() { double.Parse(product[1]), double.Parse(product[2]) });
                }
                else
                {
                    products[product[0]][0] = double.Parse(product[1]);
                    products[product[0]][1] += double.Parse(product[2]);
                }
                
                input = Console.ReadLine();
            }

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Key} -> {p.Value[0] * p.Value[1]:F2}");
            }
        }
    }
}
