using System;
using System.Linq;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < tokens.Length; j++)
                {
                    elements.Add(tokens[j]);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
