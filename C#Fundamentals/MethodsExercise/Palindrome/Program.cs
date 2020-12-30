using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int n = int.Parse(input);

                Console.WriteLine(IsPalindrome(n) == true ? "true" : "false");

                input = Console.ReadLine();
            }
        }

        static int ReverceNumber(int n)
        {
            int reverceNumber = 0;
            int x = n / 10;
            int multiplier = 1;            

            while (x > 0)
            {
                x /= 10;
                multiplier *= 10;
            }

            while (multiplier > 0)
            {
                int digit = n % 10;
                reverceNumber += digit * multiplier;
                multiplier /= 10;
                n /= 10;
            }

            return reverceNumber;
        }

        static bool IsPalindrome(int n)
        {
            int reverceN = ReverceNumber(n);

            return reverceN == n ? true : false;
        }
    }
}
