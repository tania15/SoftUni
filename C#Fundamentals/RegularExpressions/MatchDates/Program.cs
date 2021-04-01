using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>(?:[1-3]?[0-9])|(?:3[01]))([\.\-\/])(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})";
            Regex regex = new Regex(pattern);

            string dates = Console.ReadLine();

            var matches = regex.Matches(dates);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}");
            }

            //Console.WriteLine(string.Join(", ", regex.Matches(dates)));
        }
    }
}
