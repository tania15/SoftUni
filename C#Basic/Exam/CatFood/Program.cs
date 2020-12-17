using System;

namespace CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int firstGroup = 0;
            int secondGroup = 0;
            int thirdGroup = 0;

            double sum = 0.0;

            for (int i = 1; i <= count; i++)
            {
                double grams = double.Parse(Console.ReadLine());
                sum += grams;

                if (grams < 200)
                {
                    firstGroup++;
                }
                else if (grams >= 200 && grams < 300)
                {
                    secondGroup++;
                }
                else
                {
                    thirdGroup++;
                }
            }

            Console.WriteLine($"Group 1: {firstGroup} cats.");
            Console.WriteLine($"Group 2: {secondGroup} cats.");
            Console.WriteLine($"Group 3: {thirdGroup} cats.");
            Console.WriteLine($"Price for food per day: {sum/1000*12.45:F2} lv.");
        }
    }
}
