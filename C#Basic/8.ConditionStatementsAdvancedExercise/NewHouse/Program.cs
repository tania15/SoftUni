using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double value = 0;

            if (flowers == "Roses")
            {
                value += count * 5;
               
                if (count > 80)
                {
                    value -= value * 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                value += count * 3.8;
                
                if (count > 90)
                {
                    value -= value * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                value += count * 2.8;

                if (count > 80)
                {
                    value -= value * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                value += count * 3;

                if (count < 120)
                {
                    value += value * 0.15;
                }
            }
            else
            {
                value += count * 2.5;

                if (count < 80)
                {
                    value += value * 0.20;
                }
            }

            if (budget >= value)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {budget-value:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {value-budget:F2} leva more.");
            }
        }
    }
}
