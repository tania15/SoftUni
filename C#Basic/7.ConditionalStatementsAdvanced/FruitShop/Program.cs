using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double sum = 0;

            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    sum = 2.7 * qty;
                }
                else if (fruit == "apple")
                {
                    sum = 1.25 * qty;
                }
                else if (fruit == "orange")
                {
                    sum = 0.9 * qty;
                }
                else if (fruit == "grapefruit")
                {
                    sum = 1.6 * qty;
                }
                else if (fruit == "kiwi")
                {
                    sum = 3 * qty;
                }
                else if (fruit == "pineapple")
                {
                    sum = 5.6 * qty;
                }
                else if (fruit == "grapes")
                {
                    sum = 4.2 * qty;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    sum = 2.5 * qty;
                }
                else if (fruit == "apple")
                {
                    sum = 1.2 * qty;
                }
                else if (fruit == "orange")
                {
                    sum = 0.85 * qty;
                }
                else if (fruit == "grapefruit")
                {
                    sum = 1.45 * qty;
                }
                else if (fruit == "kiwi")
                {
                    sum = 2.7 * qty;
                }
                else if (fruit == "pineapple")
                {
                    sum = 5.5 * qty;
                }
                else if (fruit == "grapes")
                {
                    sum = 3.85 * qty;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (sum != 0)
            {
                Console.WriteLine($"{sum:F2}");
            }

        }
    }
}
