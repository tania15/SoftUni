using System;
using System.Collections.Generic;
using System.Linq;
using Students;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string data = Console.ReadLine();

            while (data != "end")
            {
                string[] dataStudent = data.Split().ToArray();

                string firstName = dataStudent[0];
                string lastName = dataStudent[1];
                int age = int.Parse(dataStudent[2]);
                string town = dataStudent[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = town;

                students.Add(student);

                data = Console.ReadLine();
            }

            string nameOfCity = Console.ReadLine();

            List<Student> filtered = students.Where(s => s.HomeTown == nameOfCity).ToList();

            foreach (Student student in filtered)
            {
                if (student.HomeTown == nameOfCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
