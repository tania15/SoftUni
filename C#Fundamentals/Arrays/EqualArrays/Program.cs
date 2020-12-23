using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int length1 = arr1.Length;
            int length2 = arr2.Length;

            int sum = 0;
            bool isDifference = false;
            string str = string.Empty;

            // If the lengths of array are not equal
            if (length1 != length2)
            {
                for (int i = 0; i < length2 && i < length1; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        isDifference = true;
                        break;
                    }
                }
                if (isDifference == false)
                {
                    if (length1 > length2)
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {length2} index");
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {length1} index");
                    }
                }

            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        sum = 0;
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                    else
                    {
                        sum += arr1[i];
                    }
                }

                if (sum != 0)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
            }


            // If the lengths of array are equal
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (arr1[i] != arr2[i])
            //    {
            //        sum = 0;
            //        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            //        break;
            //    }
            //    else
            //    {
            //        sum += arr1[i];
            //    }
            //}

            //if (sum != 0)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //}
        }
    }
}
