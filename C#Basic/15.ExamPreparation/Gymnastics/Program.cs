using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();
            double grade = 0.0;

            if (country == "Russia")
            {
                if (device == "ribbon")
                {
                    grade += 9.1 + 9.4;
                }
                else if (device == "hoop")
                {
                    grade += 9.3 + 9.8;
                }
                else
                {
                    grade += 9.6 + 9;
                }
            }
            else if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    grade += 9.6 + 9.4;
                }
                else if (device == "hoop")
                {
                    grade += 9.55 + 9.75;
                }
                else
                {
                    grade += 9.5 + 9.4;
                }
            }
            else
            {
                if (device == "ribbon")
                {
                    grade += 9.2 + 9.5;
                }
                else if (device == "hoop")
                {
                    grade += 9.45 + 9.35;
                }
                else
                {
                    grade += 9.7 + 15;
                }
            }

            Console.WriteLine($"The team of {country} get {grade:F3} on {device}.");
            Console.WriteLine($"{(20 - grade) / 20 * 100:F2}%");
        }
    }
}
