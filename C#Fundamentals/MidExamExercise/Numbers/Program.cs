using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = numbers.Average();

            numbers = numbers.Where(n => n > average)
                .OrderByDescending(n => n)
                .Take(5)
                .ToList();

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
