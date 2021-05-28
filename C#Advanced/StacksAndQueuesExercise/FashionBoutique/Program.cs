using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 1;

            while (stack.Count > 0)
            {                
                int num = stack.Peek();

                if (sum + num >= capacity)
                {
                    if (sum + num == capacity)
                    {
                        stack.Pop();
                    }

                    sum = 0;
                    if (stack.Count > 0)
                    {
                        count++;
                    }                                       
                }
                else
                {
                    sum += num;
                    stack.Pop();
                }
            }

            Console.WriteLine(count);
        }
    }
}
