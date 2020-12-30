using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaisePower(n, power)); 
        }

        static double RaisePower(double n, int power)
        {
            double result = 1.0;

            for (int i = 1; i <= power; i++)
            {
                result *= n;
            }

            return result;
        }
    }
}
