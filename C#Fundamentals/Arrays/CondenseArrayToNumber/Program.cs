using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] tarray = array;
            int length = array.Length;

            while (length > 0)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    int sum = array[i] + array[i + 1];
                    tarray[i] = sum;


                }
                array = tarray;
                length--;
            }

            Console.WriteLine(array[0]);           

        }
    }
}
