using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n1 = BigInteger.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 * n2);
        }
    }
}
