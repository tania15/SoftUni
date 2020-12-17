using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int totalCount = 0;
            double totalSum = 0;

            while (name != "Finish")
            {
                double sumGrades = 0;
                int count = 0;

                while (count < n)
                {
                    double grade = double.Parse(Console.ReadLine());
                    count++;
                    sumGrades += grade;

                }

                totalSum += sumGrades;
                totalCount += n;
                Console.WriteLine($"{name} - {sumGrades / n:F2}.");

                name = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalSum / totalCount:F2}.");
        }
    }
}
