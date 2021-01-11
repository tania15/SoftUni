using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in input)
            {
                if (!counts.ContainsKey(word.ToLower()))
                {
                    counts[word.ToLower()] = 0;
                }

                counts[word.ToLower()]++;
            }

            counts = counts.Where(c => c.Value % 2 == 1).ToDictionary(c => c.Key, c => c.Value);

            foreach (var c in counts)
            {
                Console.Write($"{c.Key} ");
            }
        }
    }
}
