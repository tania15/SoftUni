using System;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfFlour = double.Parse(Console.ReadLine());
            double priceOfEgg = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());

            int freeFlour = students / 5;
            double sumFlour = priceOfFlour * (students - freeFlour);
            double sum = priceOfApron * (students + Math.Ceiling(0.2 * students)) + sumFlour + priceOfEgg * 10 * students;

            if (sum > budget)
            {
                Console.WriteLine($"{sum-budget:F2}$ more needed.");
            }
            else
            {
                Console.WriteLine($"Items purchased for {sum:F2}$.");
            }
        }
    }
}
