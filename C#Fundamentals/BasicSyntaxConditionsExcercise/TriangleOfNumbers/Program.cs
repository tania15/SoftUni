﻿using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int k = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
                k++;
            }
        }
    }
}
