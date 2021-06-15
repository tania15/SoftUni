﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<(string, int), int, bool> younger = (person, age) => person.Item2 < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;

            int n = int.Parse(Console.ReadLine());
            List<(string name, int age)> people = new List<(string, int)>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people.Add((person[0], int.Parse(person[1])));
            }

            string cond = Console.ReadLine();
            int filter = int.Parse(Console.ReadLine());
            string[] printFormat = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (cond)
            {
                case "younger":
                    people = people
                        .Where(p => younger(p, filter))
                        .ToList();
                    break;
                case "older":
                    people = people
                        .Where(p => older(p, filter))
                        .ToList();
                    break;
                default:
                    break;
            }

            foreach (var person in people)
            {
                List<string> output = new List<string>();

                if (printFormat.Contains("name"))
                {
                    output.Add(person.name);
                }

                if (printFormat.Contains("age"))
                {
                    output.Add(person.age.ToString());
                }

                Console.WriteLine(string.Join(" - ", output));
            }
        }
    }
}
