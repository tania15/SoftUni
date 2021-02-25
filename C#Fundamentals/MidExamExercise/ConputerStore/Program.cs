using System;

namespace ConputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSum = 0.0m;
            string input = Console.ReadLine();

            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                totalSum += price;

                input = Console.ReadLine();
            }

            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalSum:F2}$");

                decimal taxes = totalSum * 0.2m;
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");

                if (input == "special")
                {
                    Console.WriteLine($"Total price: {(totalSum + taxes) - (totalSum + taxes) * 0.1m:F2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {(totalSum + taxes):F2}$");
                }
            }
        }
    }
}
