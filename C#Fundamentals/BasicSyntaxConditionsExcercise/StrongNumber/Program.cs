using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = number;
            int prod = 1;
            int sum = 0;

            while (n % 10 != 0)
            {
                int digit = n % 10;

                for (int i = digit; i > 0; i--)
                {
                    prod *= i;
                }

                sum += prod;
                prod = 1;
                n /= 10;
            }

            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
