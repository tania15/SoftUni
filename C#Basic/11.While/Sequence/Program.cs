using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;

            while (x <= n)
            {
                Console.WriteLine(x);

                x = x * 2 + 1;
            }
        }
    }
}
