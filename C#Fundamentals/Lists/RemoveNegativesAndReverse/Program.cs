using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = numbers
                .Where(n => n >= 0)
                .Reverse()
                .ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', result));
            }
        }
    }
}
