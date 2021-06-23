using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        public delegate int Calculate(int a);
        static void Main(string[] args)
        {
            Calculate sum = a => ++a;
            Calculate substract = a => --a;
            Calculate multiply = a => a *= 2;
            //Func<int, int> add = a => ++a;
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                switch (command.ToLower())
                {
                    case "add":
                        numbers = numbers.Select(n => sum(n)).ToArray();
                        break;
                    case "subtract":
                        numbers =  numbers.Select(n => substract(n)).ToArray();
                        break;
                    case "multiply":
                        numbers = numbers.Select(n => multiply(n)).ToArray();
                        break;
                    case "print":
                        print(numbers);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
