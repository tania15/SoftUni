using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 0;
            int excluded = 0;
            double sumGrades = 0.0;

            while (grades < 12)
            {                
                double grade = double.Parse(Console.ReadLine());
                grades++;

                if (grade >= 4)
                {
                    sumGrades += grade;
                }
                else
                {
                    excluded++;
                    if (excluded == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grades - 1} grade");
                        break;
                    }
                }

                if (grades == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {sumGrades / 12 :F2}");
                }
            }
        }
    }
}
