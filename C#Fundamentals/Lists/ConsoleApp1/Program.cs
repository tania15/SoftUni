using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();         // можем да зададем капацитет на списъка
            //List<int> nums = new List<int>(new int[] { 5, 6, 7 });
            //List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };

            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> n = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //numbers.RemoveAt(3);
            numbers.Zip(n);

            List<int> result = numbers
                .Where(n => n >= 0)                              // n се нарича предикат (всеки един елемент в колекцията)
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(' ', numbers)); 
        }
    }
}
