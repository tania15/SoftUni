using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] t = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < t.Length; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 0)
                        {
                            secondArr[i] = t[j];
                        }
                        else
                        {
                            firstArr[i] = t[j];
                        }
                        
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            firstArr[i] = t[j];
                        }
                        else
                        {
                            secondArr[i] = t[j];
                        }                        
                    }
                }
            }

            Console.WriteLine(string.Join(' ', firstArr));
            Console.WriteLine(string.Join(' ', secondArr));
        }
    }
}
