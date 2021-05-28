using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> values = new Stack<string>(input);

            while (values.Count > 1)
            {
                int first = int.Parse(values.Pop());
                string sign = values.Pop();
                int second = int.Parse(values.Pop());
                int result = 0;

                if (sign == "+")
                {
                    result = first + second;
                }
                else
                {
                    result = first - second;
                }

                values.Push(result.ToString());
            }

            Console.WriteLine(values.Peek());
        }
    }
}
