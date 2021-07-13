using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IId, IBirthdate, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthDate;

        public string Name { get; private set; }

        public int Age { get; private set; }
        public string Id { get; private set; }

        public string Birthdate { get; set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthDate;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
