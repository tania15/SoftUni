using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefineAClassPerson
{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            Members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            int age = Members.Max(p => p.Age);

            return Members.Where(p => p.Age == age).First();
        }
    }
}
