using System;
using System.Collections.Generic;
using System.Text;
using CreateClass.Places;

namespace CreateClass.Entities
{
    public class Employee : Person, ICloneable
    {
        private int _salary;
        public string Profession;
        public Room Room;
        public Employee(string name, DateTime birthDate, Gender gender, int salary, string profession) : base(name, birthDate, gender)
        {
            _salary = salary;
            Profession = profession;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(_salary)}: {_salary}, {nameof(Profession)}: {Profession}, {nameof(Room)}: {Room.RoomNumber}";
        }
    }
}
