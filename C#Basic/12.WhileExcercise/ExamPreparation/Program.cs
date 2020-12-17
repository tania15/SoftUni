using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNegativeGrades = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string lastProblem = name;
            int grade = 0;
            if (name != "Enough")
            {
                grade = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int count = 0;
            int countNegative = 0;

            while (name != "Enough")
            {
                if (countNegativeGrades == 0)
                {
                    Console.WriteLine($"You need a break, {countNegativeGrades} poor grades.");
                    break;
                }

                sum += grade;
                count++;

                if (grade <= 4)
                {
                    countNegative++;

                    if (countNegative == countNegativeGrades)
                    {
                        Console.WriteLine($"You need a break, {countNegative} poor grades.");
                        break;
                    }
                }

                lastProblem = name;
                name = Console.ReadLine();
                if (name != "Enough")
                {
                    grade = int.Parse(Console.ReadLine());
                }
            }

            if (countNegative < countNegativeGrades)
            {
                Console.WriteLine($"Average score: {sum * 1.0 / count:F2}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
