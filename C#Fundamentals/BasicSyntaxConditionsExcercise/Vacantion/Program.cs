using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double sum = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    sum = group * 8.45;
                }
                else if (day == "Saturday")
                {
                    sum = group * 9.80;
                }
                else
                {
                    sum = group * 10.46;
                }

                if (group >= 30)
                {
                    sum -= sum * 0.15;
                }
            }
            else if (type == "Business")
            {
                if (group >= 100)
                {
                    group -= 10;
                }
                
                if (day == "Friday")
                {
                    sum = group * 10.9;
                }
                else if (day == "Saturday")
                {
                    sum = group * 15.60;
                }
                else
                {
                    sum = group * 16;
                }
            }
            else
            {
                if (day == "Friday")
                {
                    sum = group * 15;
                }
                else if (day == "Saturday")
                {
                    sum = group * 20;
                }
                else
                {
                    sum = group * 22.50;
                }

                if (group >= 10 && group <= 20)
                {
                    sum -= sum * 0.05;
                }
            }

            Console.WriteLine($"Total price: {sum:F2}");
        }
    }
}
