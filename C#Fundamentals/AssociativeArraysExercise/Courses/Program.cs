using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] course = input.Split(" : ");

                if (courses.ContainsKey(course[0]))
                {
                    courses[course[0]].Add(course[1]);
                }
                else
                {
                    courses.Add(course[0], new List<string>() { course[1] });
                }

                input = Console.ReadLine();
            }

            courses = courses.OrderByDescending(n => n.Value.Count).ToDictionary(c => c.Key, c => c.Value);

            foreach (var c in courses)
            {
                Console.WriteLine($"{c.Key}: {c.Value.Count}");

                foreach (var u in c.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"-- {u}");
                }
            }
        }
    }
}
