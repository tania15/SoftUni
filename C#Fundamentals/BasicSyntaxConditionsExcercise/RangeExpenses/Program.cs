using System;

namespace RangeExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceOfHeadset = double.Parse(Console.ReadLine());
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOfKeyboard = double.Parse(Console.ReadLine());
            double priceOfDisplay = double.Parse(Console.ReadLine());

            int countHeadset = lostGames / 2;
            int countMouse = lostGames / 3;
            int countKeyboard = 0;

            for (int i = 6; i <= lostGames; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    countKeyboard++;
                }
            }

            int countDisplay = countKeyboard / 2;

            double costs = priceOfHeadset * countHeadset + priceOfMouse * countMouse + priceOfKeyboard * countKeyboard + priceOfDisplay * countDisplay;

            Console.WriteLine($"Rage expenses: {costs:F2} lv.");
        }
    }
}
