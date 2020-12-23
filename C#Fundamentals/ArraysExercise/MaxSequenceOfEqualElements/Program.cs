using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxLength = 0;
            int tempLength = 1;
            int index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                //tempLength++;

                if (arr[i + 1] == arr[i])
                {
                    tempLength++;
                    if (i == arr.Length - 1)
                    {
                        tempLength++;
                    }
                }
                else
                {
                    if (maxLength < tempLength)
                    {
                        maxLength = tempLength;
                        index = i;
                    }
                    tempLength = 1;                    
                }
            }

            if (maxLength < tempLength)
            {                
                maxLength = tempLength;
                index = arr.Length - 1;
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(arr[index] + " ");
            }
        }
    }
}
