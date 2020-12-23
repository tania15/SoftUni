using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool isEqual = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += arr[j];
                    }

                    if (j > i)
                    {
                        rightSum += arr[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (isEqual == false && arr.Length > 1)
            {
                Console.WriteLine("no");
            }

            //if (arr.Length == 1)
            //{
            //    Console.WriteLine(0);
            //}
        }
    }
}
