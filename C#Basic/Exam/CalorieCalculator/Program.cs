using System;

namespace CalorieCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char sex = char.Parse(Console.ReadLine());            
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string level = Console.ReadLine();
            double result = 0.0;

            if (sex == 'm')
            {
                result = 66 + (13.7 * weight) + (5 * height * 100) - (6.8 * age);
            }
            else
            {
                result = 655 + (9.6 * weight) + (1.8 * height * 100) - (4.7 * age);
            }

            if (level == "sedentary")
            {
                result *= 1.2;
            }
            else if (level == "lightly active")
            {
                result *= 1.375;
            }
            else if (level == "moderately active")
            {
                result *= 1.55;
            }
            else
            {
                result *= 1.725;
            }

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(result)} calories per day.");
        }
    }
}
