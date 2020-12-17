using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination;
            string type;
            double sum;

            //if (season == "Summer")
            //{
            //    type = "Camp";
            //}
            //else
            //{
            //    type = "Hotel";
            //}

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    type = "Camp";
                    sum = budget * 0.3;
                }
                else
                {
                    type = "Hotel";
                    sum = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    sum = budget * 0.4;
                }
                else
                {
                    type = "Hotel";
                    sum = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                sum = budget * 0.9;
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {sum:F2}");
        }
    }
}
