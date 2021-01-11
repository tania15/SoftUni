using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, double> informations = new Dictionary<string, double>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (informations.ContainsKey(name))
                {
                    informations[name] = (informations[name] + grade) / 2;
                }
                else
                {
                    informations[name] = grade;
                }
            }

            informations = informations.Where(i => i.Value >= 4.5).OrderByDescending(n => n.Value).ToDictionary(i => i.Key, i => i.Value);

            foreach (var i in informations)
            {
                Console.WriteLine($"{i.Key} -> {i.Value:F2}");
            }
        }
    }
}
