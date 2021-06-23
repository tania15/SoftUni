using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            Predicate<int> predicate = (n) => ((command.ToLower() == "odd")
                ? n % 2 != 0
                : n % 2 == 0);
            //Predicate<int> predicate = command.ToLower() == "odd"
            //    ? n => n % 2 != 0
            //    : new Predicate<int>(n => n % 2 == 0);

            List<int> numbers = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
