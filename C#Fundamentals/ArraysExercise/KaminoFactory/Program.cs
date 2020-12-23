using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int[] bestArr = new int[n];
            int maxLength = 0;
            int minIndex = int.MaxValue;
            int maxSum = 0;

            while (str != "Clone them!")
            {
                int[] arr = str.Split('!').Select(int.Parse).ToArray();
                int sum = 0;
                int length = 0;
                int index = int.MaxValue;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];                    

                    if (arr[i] == 1)
                    {
                        length++;
                        if (index > i && length >= maxLength)
                        {
                            index = i - length + 1;
                        }
                    }

                    if (arr[i] != 1 || (arr[i] == 1 && i == arr.Length - 1))                   
                    {                    
                        if (length == maxLength)
                        {
                            if (index == minIndex)
                            {
                                if (sum > arr.Sum() && i == arr.Length - 1)
                                {
                                    maxLength = length;
                                    bestArr = arr;
                                    maxSum = arr.Sum();
                                    minIndex = index;
                                }
                            }

                            if (index < minIndex)
                            {
                                maxLength = length;
                                bestArr = arr;
                                maxSum = arr.Sum();
                                minIndex = index;
                            }                            
                        }

                        if (maxLength < length)
                        {
                            maxLength = length;
                            bestArr = arr;
                            maxSum = arr.Sum();
                            minIndex = index;
                        }
                        length = 0;
                        index = int.MaxValue;
                    }


                }

                str = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {minIndex+1} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", bestArr));
        }
    }
}
