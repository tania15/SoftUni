using System;
using System.Linq;
using System.Collections.Generic;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Predicate<string> filter = name =>
            {
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    sum += (int)name[i];
                }

                if (sum >= n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            for (int i = 0; i < names.Length; i++)
            {
                if (filter(names[i]))
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
        }
    }
}
