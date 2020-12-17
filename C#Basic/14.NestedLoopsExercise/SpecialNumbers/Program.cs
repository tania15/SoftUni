using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int k = i;
                bool isSpecial = true;

                while (k != 0)
                {
                    int digit = k % 10;
                    k /= 10;

                    if (digit == 0 || n < digit || n % digit > 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
