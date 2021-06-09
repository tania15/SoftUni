using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (occurrences.ContainsKey(numbers[i]))
                {
                    occurrences[numbers[i]]++;
                }
                else
                {
                    occurrences.Add(numbers[i], 1);
                }
            }

            foreach(var o in occurrences)
            {
                Console.WriteLine($"{o.Key} - {o.Value} times");
            }
        }
    }
}
