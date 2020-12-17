using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double result = 48 - h;
            result = result * 3 / 4.0 + h + p * 2 / 3.0;

            if (type == "leap")
            {
                result += result * 0.15;
            }

            Console.WriteLine(Math.Floor(result));
        }
    }
}
