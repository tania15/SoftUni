using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int t = 2;

            
            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(Math.Pow(t, i));
            }
        }
    }
}
