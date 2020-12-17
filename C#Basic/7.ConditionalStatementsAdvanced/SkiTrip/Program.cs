using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine()) - 1;
            string type = Console.ReadLine();
            string service = Console.ReadLine();
            int discount;
            double price;

            if (type == "apartment")
            {
                price = 25;

                if (countDays < 10)
                {
                    discount = 30;
                }
                else if (countDays >= 10 && countDays <= 15)
                {
                    discount = 35;
                }
                else
                {
                    discount = 50;
                }
            }
            else if (type == "president apartment")
            {
                price = 35;

                if (countDays < 10)
                {
                    discount = 10;
                }
                else if (countDays >= 10 && countDays <= 15)
                {
                    discount = 15;
                }
                else
                {
                    discount = 20;
                }
            }
            else
            {
                price = 18;
                discount = 0;
            }

            double sum = price * countDays - price * countDays * discount / 100;

            if (service == "positive")
            {
                sum += sum * 0.25;
            }
            else
            {
                sum -= sum * 0.1;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
