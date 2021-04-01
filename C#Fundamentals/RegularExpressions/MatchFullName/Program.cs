using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex reg = new Regex(regex);

            Console.WriteLine(string.Join(' ', reg.Matches(text)));
        }
    }
}
