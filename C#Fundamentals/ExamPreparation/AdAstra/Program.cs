using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)([A-Za-z\s]+)\1([0-3]{1}[0-9]{1}\/[0|1][0-9]\/[1|2][0-9])\1(\d{1,4}|10000)\1";
            Regex regex = new Regex(pattern);

            string data = Console.ReadLine();
            MatchCollection foods = regex.Matches(data);
            int calories = foods
                .Select(m => int.Parse(m.Groups[4].ToString()))
                .Sum();

            Console.WriteLine($"You have food to last you for: {calories / 2000} days!");

            foreach (Match f in foods)
            {
                Console.WriteLine($"Item: {f.Groups[2].Value}, Best before: {f.Groups[3].Value}, Nutrition: {f.Groups[4].Value}");
            }
        }
    }
}
