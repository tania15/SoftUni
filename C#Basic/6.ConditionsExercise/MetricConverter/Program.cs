using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();
            double result = 1;

            if (inputMetric == "mm")
            {
                if (outputMetric == "mm")
                {
                    result = number;
                }
                else if (outputMetric == "cm")
                {
                    result = number / 10;
                }
                else
                {
                    result = number / 1000;
                }
            }
            else if (inputMetric == "cm")
            {
                if (outputMetric == "mm")
                {
                    result = number * 10;
                }
                else if (outputMetric == "cm")
                {
                    result = number;
                }
                else
                {
                    result = number / 100;
                }
            }
            else
            {
                if (outputMetric == "mm")
                {
                    result = number * 1000;
                }
                else if (outputMetric == "cm")
                {
                    result = number * 100;
                }
                else
                {
                    result = number;
                }
            }

            Console.WriteLine($"{result:F3}");
        }
    }
}
