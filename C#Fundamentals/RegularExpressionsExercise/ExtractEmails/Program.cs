using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([A-z]+[A-z\.\-_]*[A-z])@([A-z]+[A-z\.\-]*\.[A-z]+)";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
