using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(bullets);
            Queue<int> queue = new Queue<int>(locks);
            int value = int.Parse(Console.ReadLine());
            
            int count = 0;
            int useBullets = 0;

            while (stack.Count > 0 && queue.Count > 0)
            {
                if (stack.Peek() <= queue.Peek())
                {
                    Console.WriteLine("Bang!");
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    stack.Pop();
                }

                count++;

                if (count == size && stack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

                useBullets++;
            }

            if (stack.Count >= 0 && queue.Count == 0)
            {
                int earned = value - useBullets * priceOfBullet;
                Console.WriteLine($"{stack.Count} bullets left. Earned ${earned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
            }
        }
    }
}
