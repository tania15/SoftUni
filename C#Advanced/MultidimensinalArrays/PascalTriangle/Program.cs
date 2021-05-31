using System;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            long[][] pascal = new long[size][];
            
            pascal[0] = new long[1] { 1 };
            
            if (size >= 2)
            {
                pascal[1] = new long[2] { 1, 1};
            }

            if (size >= 3)            
            {
                for (int i = 2; i < size; i++)
                {
                    pascal[i] = new long[i + 1];

                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            pascal[i][j] = 1;
                        }
                        else 
                        {
                            pascal[i][j] = pascal[i - 1][j] + pascal[i - 1][j - 1];
                        }
                    }
                }
            }

            foreach(long[] p in pascal)
            {
                Console.WriteLine(string.Join(" ", p));
            }
        }
    }
}
