using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Pet : IBirthdate
    {
        private string name;
        private string birthDate;

        public string Name { get; private set; }
        public string Birthdate { get; set; }

        public Pet(string name, string birthDate)
        {
            Name = name;
            Birthdate = birthDate;
        }
    }
}
