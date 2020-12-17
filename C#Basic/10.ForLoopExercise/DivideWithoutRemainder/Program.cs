using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    p1Count++;
                }
                if (x % 3 == 0)
                {
                    p2Count++;
                }
                if (x % 4 == 0)
                {
                    p3Count++;
                }
            }

            double p1 = p1Count * 1.0 / n * 100;
            double p2 = p2Count * 1.0 / n * 100;
            double p3 = p3Count * 1.0 / n * 100;
            
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
