using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!grades.ContainsKey(input[0]))               
                {
                    grades.Add(input[0], new List<decimal>());                    
                }

                grades[input[0]].Add(decimal.Parse(input[1]));
            }

            foreach (var g in grades)
            {
                Console.WriteLine($"{g.Key} -> {string.Join(" ", g.Value.Select(v => v.ToString("F2")))} (avg: {g.Value.Average():F2})");         //Select(v:F2)
            }
        }
    }
}
