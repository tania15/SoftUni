using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int n)
        {
            if (IsDivisible(n) && HaveOdd(n))
            {
                return true;
            }

            return false;
        }

        static bool IsDivisible(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool HaveOdd(int n)
        {
            while (n > 0)
            {
                int digit = n % 10;
                n /= 10;

                if (digit % 2 == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
