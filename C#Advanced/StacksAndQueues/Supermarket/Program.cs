using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            while (input.ToLower() != "end")
            {
                if (input.ToLower() != "paid")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
