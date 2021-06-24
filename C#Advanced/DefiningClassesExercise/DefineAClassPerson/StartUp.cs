using DefineAClassPerson;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // task 3
            //int n = int.Parse(Console.ReadLine());
            //Family family = new Family();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] person = Console.ReadLine()
            //        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();

            //    Person member = new Person(person[0], int.Parse(person[1]));
            //    family.AddMember(member);
            //}

            //Person oldestMember = family.GetOldestMember();

            //Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");


            // task 4
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(person[0], int.Parse(person[1])));
            }

            //people = people.Where(p => p.Age >= 30).OrderBy(p => p.Name).ToList();

            foreach (Person p in people.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine(p);
            }
        }
    }
}
