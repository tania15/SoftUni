using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());

            double shoes = fee * 0.6;
            double equipment = shoes - shoes * 0.2;
            double ball = equipment / 4;
            double accessories = ball / 5;

            Console.WriteLine($"{fee + shoes + equipment + ball+ accessories:F2}");
        }
    }
}
