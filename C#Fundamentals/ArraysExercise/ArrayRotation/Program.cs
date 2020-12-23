using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            //int[] temp = new int[arr.Length];
            //int index = 0;

            //if (n > arr.Length)
            //{
            //    n -= arr.Length;
            //}

            //for (int i = n; i < arr.Length; i++, index++)
            //{
            //    temp[index] = arr[i];
            //}

            //for (int i = 0; i < n; i++, index++)
            //{
            //    temp[index] = arr[i];
            //}

            //Console.WriteLine(string.Join(' ', temp));


            // second solution withouth temp array
            for (int i = 0; i < n; i++)
            {
                int temp = arr[0];

                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }
                arr[arr.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
