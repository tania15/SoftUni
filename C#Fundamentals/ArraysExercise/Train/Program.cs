﻿using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
                //Console.Write($"{arr[i]} ");
            }

            //Console.WriteLine();
            Console.WriteLine(string.Join(' ', arr));           
            Console.WriteLine(sum);
        }
    }
}
