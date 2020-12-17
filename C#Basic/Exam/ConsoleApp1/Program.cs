using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBoxes = int.Parse(Console.ReadLine());
            int countRollers = int.Parse(Console.ReadLine());
            double priceGloves = double.Parse(Console.ReadLine());
            double priceBrush = double.Parse(Console.ReadLine());

            Console.WriteLine($"This delivery will cost {(countBoxes * 21.5 + countRollers * 5.2 + Math.Ceiling(countRollers * 0.35) * priceGloves + Math.Floor(countBoxes * 0.48) * priceBrush) / 15:F2} lv.");
        }
    }
}
