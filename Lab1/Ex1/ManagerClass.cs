using System;
using EmployeeClass;

namespace ManagerClass
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, DateTime startDate, double salary) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StartDate = startDate;
            this.Salary = salary;
        }

        public Manager(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string Salutation() {
            return "Hello manager!";
        }
    }
}