using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            string type = string.Empty;
            double money = 0.0;
            int countSpend = 0;
            int countDays = 0;

            while (countSpend < 5 && priceOfVacation > availableMoney)
            {
                type = Console.ReadLine();
                money = double.Parse(Console.ReadLine());

                if (type == "spend")
                {                   
                    availableMoney -= money;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    countSpend++;
                    if (countSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(5);
                        break;
                    }
                }
                else
                {
                    availableMoney += money;
                    countSpend = 0;
                }

                countDays++;
            }

            if (countSpend < 5)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}
