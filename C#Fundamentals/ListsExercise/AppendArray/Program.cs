using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                   .Split('|', StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int[] numbersArray = numbers[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (numbersArray.Length != 0)
                {
                    Console.Write(string.Join(' ', numbersArray));

                    if (i != 0)
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
