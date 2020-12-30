using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            CalculatePrice(product, count);
        }

        static void CalculatePrice(string product, int count)
        {
            switch (product)
            {
                case "coffee": Console.WriteLine($"{count * 1.5:F2}"); break;
                case "water": Console.WriteLine($"{count * 1:F2}"); break;
                case "coke": Console.WriteLine($"{count * 1.4:F2}"); break;
                case "snacks": Console.WriteLine($"{count * 2:F2}"); break;
                default: Console.WriteLine(); break;
            }
        }
    }
}
