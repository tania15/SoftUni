using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] specialNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumbers[0])
                {
                    int minIndex = (i - specialNumbers[1] > 0 ? i - specialNumbers[1] : 0);
                    int maxIndex = (i + specialNumbers[1] <= numbers.Count ? i + specialNumbers[1] : numbers.Count-1);
                    int count = maxIndex - minIndex;                  

                    for (int j = minIndex; j <= maxIndex; j++)
                    {
                        numbers.RemoveAt(minIndex);
                    }

                    //numbers.RemoveRange(...);

                    i = minIndex - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
