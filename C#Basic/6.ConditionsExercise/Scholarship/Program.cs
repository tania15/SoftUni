using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            if (income > minSalary && success < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minSalary && success >= 4.50 && success < 5.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(minSalary * 0.35)} BGN");
            }
            else if (income >= minSalary && success >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(success * 25)} BGN");
            }
            else 
            {
                if (minSalary * 0.35 > success * 25)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(minSalary * 0.35)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(success * 25)} BGN");
                }

            }
        }
    }
}
