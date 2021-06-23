using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int divisibleNumber = int.Parse(Console.ReadLine());

            Predicate<int> filter = n => n % divisibleNumber != 0;
            Action<int[]> printer = nums => Console.WriteLine(string.Join(" ", nums.Reverse().Where(n => filter(n))));
            printer(numbers);
        }
    }
}
