using System;
using System.Linq;

namespace KaminoFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int length = int.MinValue;
            int index = 0;
            int[] array = new int[n];
            int sum = int.MinValue;

            while (str != "Clone them!")
            {
                int[] arr = str.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int tLength = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    //int current = arr[i];

                    while (i < arr.Length && arr[i] == 1)
                    {
                        tLength++;
                        i++;
                    }
                    if (tLength > 0)
                    {
                        i--;
                    }

                    if (length < tLength)
                    {
                        length = tLength;
                        index = i - length + 1;
                        array = arr;
                        sum = array.Sum();
                    }

                    if (length == tLength)
                    {
                        if (i < index)
                        {
                            index = i - length + 1;
                            array = arr;
                            sum = array.Sum();
                        }

                        if (i == index)
                        {
                            if (sum > arr.Sum())
                            {
                                array = arr;
                            }
                        }
                    }
                    tLength = 0;                    
                }

                str = Console.ReadLine();
            }

            //Console.WriteLine("length: " + length);
            //Console.WriteLine("index: " + index);
            //Console.WriteLine("array: " + string.Join(' ', array));
            //Console.WriteLine("sum: " + array.Sum());

            Console.WriteLine($"Best DNA sample {index + 1} with sum: {array.Sum()}.");
            Console.WriteLine(string.Join(' ', array) + ' ');
        }
    }
}
