using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            Console.WriteLine(string.Join(" ", arr.Reverse()));

            // Console.WriteLine(string.Join(' ', Console.ReadLine().Split().Reverse()));
        }
    }
}
