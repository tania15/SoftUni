using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int factorialOfN = Factorial(n);
            int factorialOfK = Factorial(k);


            Console.WriteLine($"{factorialOfN * 1.0 / factorialOfK:F2}");
        }

        static int Factorial(int n)
        {
            int prod = 1;

            for (int i = 1; i <= n; i++)
            {
                prod *= i;
            }

            return n == 0 ? 0 : prod;
        }
    }
}
