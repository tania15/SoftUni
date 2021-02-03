using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive.");
                }
                age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


    }
}
