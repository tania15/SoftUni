using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());

            double costs = (countStudents + Math.Ceiling(countStudents * 0.1)) * priceOfLightsabers + priceOfBelts * countStudents + (countStudents - countStudents / 6) * priceOfRobes;

            if (costs > budget)
            {
                Console.WriteLine($"Ivan Cho will need {costs-budget:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {costs:F2}lv.");
            }
        }
    }
}
