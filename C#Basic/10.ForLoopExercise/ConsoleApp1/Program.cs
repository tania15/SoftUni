using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxEven = double.MinValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double minOdd = double.MaxValue;

            double sumEven = 0.0;
            double sumOdd = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += x;

                    if (maxEven < x)
                    {
                        maxEven = x;
                    }
                    if (minEven > x)
                    {
                        minEven = x;
                    }
                }
                else
                {
                    sumOdd += x;

                    if (maxOdd < x)
                    {
                        maxOdd = x;
                    }
                    if (minOdd > x)
                    {
                        minOdd = x;
                    }
                }
            }

            Console.WriteLine($"OddSum={sumOdd:F2},");

            if (minOdd == 0 || minOdd == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:F2},");
            }

            if (maxOdd == 0 || maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:F2},");
            }

            Console.WriteLine($"EvenSum={sumEven:F2},");

            if (minEven == 0 || minEven == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:F2},");
            }

            if (maxEven == 0 || maxEven == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:F2}");
            }
        }
    }
}
