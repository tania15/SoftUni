using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            PrintMin(x, y, z);
        }

        static void PrintMin(int x, int y, int z)
        {
            if (x < y && x < z)
            {
                Console.WriteLine(x);
            }
            else if (y < x && y < z)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(z);
            }
        }
    }
}
