using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0.0;

            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);
                sum += money;

                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    sum -= money;
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {money:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
