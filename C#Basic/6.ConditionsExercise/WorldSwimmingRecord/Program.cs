using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double result = meters * time + Math.Round(Math.Round(meters / 15) * 12.5, 2);

            if (record > result)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {result - record:F2} seconds slower.");
            }
        }
    }
}
