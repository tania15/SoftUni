using System;
using System.Linq;

namespace EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    sumEven += n;
                }
                else
                {
                    sumOdd += n;
                }
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
