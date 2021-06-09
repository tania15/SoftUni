using System;
using System.Linq;
using System.Collections.Generic;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            HashSet<int> repeated = new HashSet<int>();

            for (int i = 0; i < sizes[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            for (int i = 0; i < sizes[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
                
            }

            foreach (int f in firstSet)
            {
                if (secondSet.Contains(f))
                {
                    repeated.Add(f);
                }
            }

            if (repeated.Count > 0)
            {
                Console.WriteLine(string.Join(" ", repeated));
            }
        }
    }
}
