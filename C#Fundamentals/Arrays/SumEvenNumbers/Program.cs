using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
