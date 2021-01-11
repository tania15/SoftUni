using System;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(number => int.Parse(number))
                .ToArray();

            int[] result = nums.Select(n =>
            {
                int p = n % 10;
                return p;
            })
                .ToArray();

            // predicat - returns boolean value
            // where - взима елементитете които изпълняват дадено условие

            // тип за записване на ламбда израз
            Func<int, bool> isEven = n => n % 2 == 0;
            int[] evenNumbers = nums
                .Where(isEven)
                .ToArray();


            Console.ReadLine()
                .Split()
                .Where(word => word.Length % 2 == 0)
                .ToList()
                .ForEach(word => Console.WriteLine(word));


        }
    }
}
