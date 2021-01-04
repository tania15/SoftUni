using System;
using System.Linq;
using System.Collections.Generic;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxLength = numbers.Count / 2;
            for (int i = 0; i < maxLength; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
