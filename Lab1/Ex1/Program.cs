using System;
using ManagerClass;
using ArchitectClass;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager
            Manager manager = new Manager("Ion", "Dragu");
            Console.WriteLine("Hello " + manager._FirstName + "!\n");

            manager._StartDate = new DateTime(2019, 8, 1, 8, 0, 0);
            manager._EndDate = new DateTime(2021, 7, 1, 8, 0, 0);

            DateTime current = DateTime.Now;
            Console.WriteLine(manager.IsActive(current) + "\n");

            //Architect
            Architect architect = new Architect("Ana", "Stan");
            Console.WriteLine("Hello " + architect._FirstName + "!\n");

            architect._StartDate = new DateTime(2019, 8, 1, 8, 0, 0);
            architect._EndDate = new DateTime(2022, 7, 1, 8, 0, 0);

            Console.WriteLine(architect.IsActive(current) + "\n");
        }
    }
}
