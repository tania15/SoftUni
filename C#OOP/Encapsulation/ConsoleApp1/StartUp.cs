using System;
using System.Linq;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            // first task
            //var lines = int.Parse(Console.ReadLine());
            //var people = new List<PersonsInfo.Person>();

            //for (int i = 0; i < lines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    var person = new PersonsInfo.Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            //    people.Add(person);
            //}

            //people.OrderBy(p => p.FirstName)
            //    .ThenBy(p => p.Age)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ToString()));


            // second task
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<PersonsInfo.Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new PersonsInfo.Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }

            //var parcentage = decimal.Parse(Console.ReadLine());
            //persons.ForEach(p => p.IncreaseSalary(parcentage));
            //persons.ForEach(p => Console.WriteLine(p.ToString()));


            // third task
            Team team = new Team("SoftUni");
            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team);
        }
    }
}
