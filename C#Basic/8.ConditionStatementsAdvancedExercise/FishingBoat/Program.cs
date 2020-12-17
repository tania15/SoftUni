using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double costs;

            if (season == "Spring")
            {
                costs = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                costs = 4200;
            }
            else
            {
                costs = 2600;
            }

            if (count <= 6)
            {
                costs -= costs * 0.1;
            }
            else if (count > 6 && count <= 11)
            {
                costs -= costs * 0.15;
            }
            else
            {
                costs -= costs * 0.25;
            }

            if (count % 2 == 0 && season != "Autumn")
            {
                costs -= costs * 0.05;
            }

            if (costs <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - costs:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {costs - budget:F2} leva.");
            }
        }
    }
}
