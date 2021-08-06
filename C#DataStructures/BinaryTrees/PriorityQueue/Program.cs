using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            List<int> elements = new List<int> { 15, 25, 6, 9, 5, 8, 17, 16 };

            foreach(int e in elements)
            {
                queue.Add(e);
            }

            while (queue.Size > 0)
            {
                Console.WriteLine($"Max element: {queue.Dequeue()}");
            }
        }
    }
}
