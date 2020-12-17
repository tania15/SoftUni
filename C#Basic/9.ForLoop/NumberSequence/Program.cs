using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int min = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = x;
                    min = x;
                }
                else
                {
                    if (max < x)
                    {
                        max = x;
                    }

                    if (min > x)
                    {
                        min = x;
                    }
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
