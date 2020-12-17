using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double sum = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    sum = qty * 0.5;
                }
                else if (product == "water")
                {
                    sum = qty * 0.8;
                }
                else if (product == "beer")
                {
                    sum = qty * 1.2;
                }
                else if (product == "sweets")
                {
                    sum = qty * 1.45;
                }
                else
                {
                    sum = qty * 1.6;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    sum = qty * 0.4;
                }
                else if (product == "water")
                {
                    sum = qty * 0.7;
                }
                else if (product == "beer")
                {
                    sum = qty * 1.15;
                }
                else if (product == "sweets")
                {
                    sum = qty * 1.3;
                }
                else
                {
                    sum = qty * 1.5;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    sum = qty * 0.45;
                }
                else if (product == "water")
                {
                    sum = qty * 0.7;
                }
                else if (product == "beer")
                {
                    sum = qty * 1.1;
                }
                else if (product == "sweets")
                {
                    sum = qty * 1.35;
                }
                else
                {
                    sum = qty * 1.55;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
