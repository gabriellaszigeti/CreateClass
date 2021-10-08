using CreateClass.Entities;
using CreateClass.Places;
using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");

            Employee Kovacs = new Employee("Géza", DateTime.Now, Gender.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
