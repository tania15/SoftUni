using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int sumEven = 0;
                int sumOdd = 0;
                int number = i;
                int position = 6;

                while (number != 0)
                {
                    int digit = number % 10;
                    number /= 10;

                    if (position % 2 == 0)
                    {
                        sumEven += digit;
                    }
                    else
                    {
                        sumOdd += digit;
                    }

                    position--;
                }

                if (sumEven == sumOdd)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
