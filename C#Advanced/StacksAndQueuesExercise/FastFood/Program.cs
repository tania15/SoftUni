using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            int sum = 0;

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                int value = queue.Peek();
                sum += value;

                if (sum <= quantity)
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
