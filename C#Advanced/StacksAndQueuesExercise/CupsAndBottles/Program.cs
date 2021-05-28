using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottles = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(bottles);
            Queue<int> queue = new Queue<int>(cups);

            int wastedWater = 0;

            while (stack.Count > 0 && queue.Count > 0)
            {
                int cup = queue.Dequeue();
                int bottle = stack.Pop();

                if (cup <= bottle)
                {
                    wastedWater += bottle - cup;
                }
                else
                {
                    cup = cup - bottle;

                    while (cup > 0)
                    {
                        bottle = stack.Pop();
                        cup = cup - bottle;
                    }

                    wastedWater -= cup;
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', stack)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(' ', queue)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");        
        
        }
    }
}

