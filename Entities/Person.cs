using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass.Entities
{
    public class Person
    {
        public string Name;
        public DateTime BirthDate;
        public Gender gender;

        public Person(string name, DateTime birthDate, Gender gender)
        {
            Name = name;
            BirthDate = birthDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(BirthDate)}={BirthDate}}}";
        }
    }
}
