using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceMashine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            double sum = 0;
            int p = 10;

            for (int i = 1; i <= age; i += 2)
            {
                sum += priceToys;
            }
            for (int i = 2; i <= age; i += 2)
            {
                sum += p;
                sum--;
                p += 10;
            }

            if (sum >= priceMashine)
            {
                Console.WriteLine($"Yes! {sum - priceMashine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceMashine - sum:F2}");
            }
        }
    }
}
