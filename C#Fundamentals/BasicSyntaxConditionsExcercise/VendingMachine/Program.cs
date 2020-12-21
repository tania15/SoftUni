using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = string.Empty;
            double sum = 0;

            do
            {
                money = Console.ReadLine();

                if (money != "Start")
                {
                    double moneyDouble = double.Parse(money);
                    if (moneyDouble != 0.1 && moneyDouble != 0.2 && moneyDouble != 0.5 && moneyDouble != 1 && moneyDouble != 2)
                    {
                        Console.WriteLine($"Cannot accept {moneyDouble}");
                    }
                    else
                    {
                        sum += moneyDouble;
                    }
                }
            } while (money != "Start");

            string product = string.Empty;

            do
            {
                product = Console.ReadLine();

                if (product != "End")
                {
                    if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                    {
                        Console.WriteLine("Invalid product");
                    }
                    else
                    {
                        if (product == "Nuts")
                        {
                            if (sum - 2 >= 0)
                            {
                                Console.WriteLine("Purchased nuds");
                                sum -= 2;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else if (product == "Water")
                        {
                            if (sum - 0.7 >= 0)
                            {
                                Console.WriteLine("Purchased water");
                                sum -= 0.7;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else if (product == "Crisps")
                        {
                            if (sum - 1.5 >= 0)
                            {
                                Console.WriteLine("Purchased crisps");
                                sum -= 1.5;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else if (product == "Soda")
                        {
                            if (sum - 0.8 >= 0)
                            {
                                Console.WriteLine("Purchased soda");
                                sum -= 0.8;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                        else
                        {
                            if (sum - 1 >= 0)
                            {
                                Console.WriteLine("Purchased coke");
                                sum -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                        }
                    }
                }
            } while (product != "End");

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
