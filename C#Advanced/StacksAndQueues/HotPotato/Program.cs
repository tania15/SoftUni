﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(kids);

            while (queue.Count > 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
