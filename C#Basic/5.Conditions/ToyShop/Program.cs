using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int countP = int.Parse(Console.ReadLine());
            int countK = int.Parse(Console.ReadLine());
            int countB = int.Parse(Console.ReadLine());
            int countM = int.Parse(Console.ReadLine());
            int countT = int.Parse(Console.ReadLine());
            int discount = 0;

            if (countP + countK + countB + countM + countT >= 50)
            {
                discount = 25;
            }

            double sum = countP * 2.6 + countK * 3 + countB * 4.1 + countM * 8.2 + countT * 2;
            if (discount > 0)
            {
                sum -= sum * discount / 100;
            }
            sum -= sum * 10 / 100;

            if (sum >= price)
            {
                Console.WriteLine($"Yes! {sum - price:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {price - sum:F2} lv needed.");
            }
        }
    }
}
