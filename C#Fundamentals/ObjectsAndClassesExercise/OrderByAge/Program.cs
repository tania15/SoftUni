using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (data != "End")
            {
                string[] studentData = data.Split(' ');

                Student student = new Student(studentData[0], studentData[1], int.Parse(studentData[2]));
                students.Add(student);

                data = Console.ReadLine();
            }

            students = students.OrderBy(x => x.Age).ToList();

            foreach (Student st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}
