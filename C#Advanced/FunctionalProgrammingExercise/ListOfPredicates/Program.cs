using System;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> filter = (n, d) => n % d == 0;

            for (int i = 1; i <= n; i++)
            {
                bool isDivide = true;

                for (int j = 0; j < dividers.Length; j++)
                {
                    if (filter(i, dividers[j]) == false)
                    {
                        isDivide = false;
                        break;
                    }
                }

                if (isDivide)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
