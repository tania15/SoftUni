using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student : Person
    {
        public bool IsStupid { get; set; }

        public Student()
        {
            Console.WriteLine("Student constructor");
        }
    }
}
