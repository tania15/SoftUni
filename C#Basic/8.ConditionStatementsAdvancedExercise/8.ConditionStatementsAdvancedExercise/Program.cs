using System;

namespace _8.ConditionStatementsAdvancedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double result = 0;

            if (type == "Premiere")
            {
                result = r * c * 12;
            }
            else if (type == "Normal")
            {
                result = r * c * 7.5;
            }
            else
            {
                result = r * c * 5;
            }

            Console.WriteLine("{0:F2} leva", result);
        }
    }
}
