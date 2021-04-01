using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string patternInput = @"%([A-Z][a-z]+)%[^|%$.]*<([A-z]+)>[^|%$.]*\|(\d+)\|[^0-9|%$.]*?(\d+\.?\d*)\$";
            //string patternInput = @"^[^|$%.]*%([A-Z][a-z]+)%[^|%$.]*<([A-z]+)>[^|$%.]*\|(\d+)\|[^0-9|%$.]*(\d+(\.\d+)?)[^|$%.]*\$$";
            string patternInput = @"^[^|$%.]*%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)[^|$%.]*\$$";
            Regex regexInput = new Regex(patternInput);
            decimal sum = 0.0m;

            while (input != "end of shift")
            {
                if (regexInput.IsMatch(input))
                {
                    string name = regexInput.Match(input).Groups[1].Value;
                    string product = regexInput.Match(input).Groups[2].Value;
                    int qty = int.Parse(regexInput.Match(input).Groups[3].Value);
                    decimal price = decimal.Parse(regexInput.Match(input).Groups[4].Value);

                    sum += price * qty;

                    Console.WriteLine($"{name}: {product} - {(price * qty):F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {sum:F2}");
        }
    }
}
