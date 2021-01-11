using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] submission = input.Split('-');

                if (submission[1] != "banned")
                {
                    if (submissions.ContainsKey(submission[1]))
                    {
                        submissions[submission[1]]++;
                    }
                    else
                    {
                        submissions.Add(submission[1], 1);
                    }

                    if (students.ContainsKey(submission[0]))
                    {
                        if (students[submission[0]] < int.Parse(submission[2]))
                        {
                            students[submission[0]] = int.Parse(submission[2]);
                        }
                    }
                    else
                    {
                        students.Add(submission[0], int.Parse(submission[2]));
                    }
                }
                else
                {
                    students.Remove(submission[0]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results: ");

            foreach (var s in students.OrderByDescending(g => g.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{s.Key} | {s.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var s in submissions.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{s.Key} - {s.Value}");
            }
        }
    }
}
