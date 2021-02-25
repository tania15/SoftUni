using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            int hours = 0;

            while (countStudents > 0)
            {
                countStudents -= firstEmployee + secondEmployee + thirdEmployee;
                hours++;

                if (hours == 3 && countStudents > 0)
                {
                    hours++;
                }

                if ((hours - 3) % 4 == 0 && countStudents > 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
