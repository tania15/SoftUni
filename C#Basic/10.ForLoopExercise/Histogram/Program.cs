using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;
            int p4Count = 0;
            int p5Count = 0;
                    
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 200)
                {
                    p1Count++;
                }
                else if (x >= 200 && x <= 399)
                {
                    p2Count++;
                }
                else if (x >= 400 && x <= 599)
                {
                    p3Count++;
                }
                else if (x >= 600 && x <= 799)
                {
                    p4Count++;
                }
                else
                {
                    p5Count++;
                }
            }

            double p1 = p1Count * 1.0 / n * 100;
            double p2 = p2Count * 1.0 / n * 100;
            double p3 = p3Count * 1.0 / n * 100;
            double p4 = p4Count * 1.0 / n * 100;
            double p5 = p5Count * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
