using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            Regex regex = new Regex(@"\+359 2(?:-| )\d{3}(?:-| )\d{4}");

            Console.WriteLine(string.Join(", ", regex.Matches(phones)));

        }
    }
}
