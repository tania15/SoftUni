using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public int Capacity { get; }
        public int Count => students.Count;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
            //Count = 0;
        }

        public string RegisterStudent(Student student)
        {
            if (Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Exists(s => s.FirstName == firstName && s.LastName == lastName))
            {
                students.Remove(students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();

            if (students.Where(s => s.Subject == subject).Count() > 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var s in students.Where(s => s.Subject == subject))
                {
                    sb.AppendLine($"{s.FirstName} {s.LastName}");
                }
            }
            else
            {
                sb.AppendLine("No students enrolled for the subject");
            }

            return sb.ToString().TrimEnd();
        }

        public int GetStudentsCount() => Count;

        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        }
    }
}
