using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto = double.Parse(Console.ReadLine());
            int count = 0;            

            while (resto - 2 >= 0)
            {
                resto = Math.Round(resto - 2.0, 2);
                count++;
            }

            while (resto - 1 >= 0)
            {
                resto = Math.Round(resto - 1.0, 2);
                count++;
            }

            while (resto - 0.5 >= 0)
            {
                resto = Math.Round(resto - 0.5, 2); ;
                count++;
            }

            while (resto - 0.2 >= 0)
            {
                resto = Math.Round(resto - 0.2, 2); ;
                count++;
            }

            while (resto - 0.1 >= 0)
            {
                resto = Math.Round(resto - 0.1, 2); ;
                count++;
            }

            while (resto - 0.05 >= 0)
            {
                resto = Math.Round(resto - 0.05, 2); ;
                count++;
            }

            while (resto - 0.02 >= 0.0)
            {
                resto = Math.Round(resto - 0.02, 2); ;
                count++;
            }

            while (resto - 0.01 >= 0.0)
            {
                resto = Math.Round(resto - 0.01, 2); ;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
