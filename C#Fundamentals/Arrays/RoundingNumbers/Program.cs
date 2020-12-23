using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double d = 0;
                if (numbers[i] != 0)
                {
                    d = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                }
                Console.WriteLine($"{numbers[i]} => {d}");
            }
        }
    }
}
