using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);

            Console.WriteLine(GetMultipleOfEvenAndOdds(n)); 
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            return (GetSumOfEvenDigits(n) * GetSumOfOddDigits(n));
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                n = n / 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                n = n / 10;

                if (digit % 2 == 1)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}
