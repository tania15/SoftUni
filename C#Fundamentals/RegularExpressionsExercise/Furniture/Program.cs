using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+(\.[0-9]+)?)!(\d+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            decimal totalPrice = 0.0M;
            //List<string> names = new List<string>();

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    decimal price = decimal.Parse(match.Groups[2].Value);
                    int qty = int.Parse(match.Groups[4].Value);

                    totalPrice += price * qty;
                    //names.Add(name);
                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
            }

            //Console.WriteLine("Bought furniture:");
            //Console.WriteLine(string.Join(Environment.NewLine, names));

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
