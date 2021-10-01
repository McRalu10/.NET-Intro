using System;
using EmployeeClass;

namespace ArchitectClass
{
    public class Architect : Employee
    {
        public Architect(string firstName, string lastName, DateTime startDate, double salary) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StartDate = startDate;
            this.Salary = salary;
        }

        public Architect(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string Salutation() {
            return "Hello architect!";
        }
    }
}