using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                Student student = new Student(data[0], data[1], double.Parse(data[2]));

                students.Add(student);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            foreach(Student s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
