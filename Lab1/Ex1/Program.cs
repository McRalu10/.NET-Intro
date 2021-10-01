using System;

namespace Lab_1
{
    class Program
    {
        public class Employee {

            protected Guid Id { get; set;}
            public string FirstName { get;}

            public Employee(string name){
                this.FirstName =  name;
            }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee("Ion");
            Console.WriteLine("Hello" + employee.FirstName + "!");
        }
    }
}
