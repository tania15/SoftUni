using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());
            double commission = 0;

            if (city == "Sofia")
            {
                if (sale >= 0 && sale <= 500)
                {
                    commission = sale * 0.05;
                }
                else if (sale > 500 && sale <= 1000)
                {
                    commission = sale * 0.07;
                }
                else if (sale > 1000 && sale <= 10000)
                {
                    commission = sale * 0.08;
                }
                else if (sale > 10000)
                {
                    commission = sale * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sale >= 0 && sale <= 500)
                {
                    commission = sale * 0.045;
                }
                else if (sale > 500 && sale <= 1000)
                {
                    commission = sale * 0.075;
                }
                else if (sale > 1000 && sale <= 10000)
                {
                    commission = sale * 0.1;
                }
                else if (sale > 10000)
                {
                    commission = sale * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sale >= 0 && sale <= 500)
                {
                    commission = sale * 0.055;
                }
                else if (sale > 500 && sale <= 1000)
                {
                    commission = sale * 0.08;
                }
                else if (sale > 1000 && sale <= 10000)
                {
                    commission = sale * 0.12;
                }
                else if (sale > 10000)
                {
                    commission = sale * 0.145;
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

            if (commission != 0)
            {
                Console.WriteLine($"{commission:F2}");
            }
        }
    }
}
