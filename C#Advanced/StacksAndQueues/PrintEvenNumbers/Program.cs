using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> result = new List<int>();

            Queue<int> queue = new Queue<int>(numbers);

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    result.Add(queue.Peek());
                }

                queue.Dequeue();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
