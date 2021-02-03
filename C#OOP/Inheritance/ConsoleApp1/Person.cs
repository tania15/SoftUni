using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Sleeping!");
        }

        public Person()
        {
            Name = "ffff";
            Console.WriteLine("Person constructor");
        }

        //public Person(string name)
        //{
        //    Name = name;
        //}
    }
}
