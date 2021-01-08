using System;
using System.Collections.Generic;
using System.Text;

namespace OrderByAge
{
    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Student(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
