using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseSrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToArray();
            Stack<char> str = new Stack<char>(input);

            while (str.Count > 0)
            {
                Console.Write(str.Pop());
            }

            Console.WriteLine();
        }
    }
}
