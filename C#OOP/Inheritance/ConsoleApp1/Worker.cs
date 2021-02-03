using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Worker : Person
    {
        public string Company { get; set; }
        public bool IsLazy { get { return true; } }

        public Worker()
        {
            Console.WriteLine("Worker constructor");
        }

        public Worker(string company, string name) 
        {
            Company = company;
            base.Name = name;

        }
    }
}
