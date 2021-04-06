using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string isValidPattern = @"!([A-Z][a-z]{2,})!:\[([A-z]{8,})\]";
            Regex isValidRegex = new Regex(isValidPattern);

            for (int i = 1; i <= number; i++)
            {
                string message = Console.ReadLine();

                if (isValidRegex.IsMatch(message))
                {
                    string text = isValidRegex.Match(message).Groups[2].Value;

                    Console.Write(isValidRegex.Match(message).Groups[1].Value + ": ");

                    foreach (var t in text)
                    {
                        Console.Write((int)t + " ");                        
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
