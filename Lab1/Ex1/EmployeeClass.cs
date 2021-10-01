using System;

namespace EmployeeClass
{
    public abstract class Employee
    {
        protected Guid Id { get;}
        protected string FirstName { get; set;}
        protected string LastName { get; set;}
        protected DateTime StartDate { get; set;}
        protected DateTime EndDate { get; set;}
        protected double Salary { get; set;}

        public Guid _Id {
            get => Id;
        }

        public string _FirstName {
            get => FirstName;
            set => FirstName = value;
        }

        public string _LastName {
            get => LastName;
            set => LastName = value;
        }

        public DateTime _StartDate {
            get => StartDate;
            set => StartDate = value;
        }

        public DateTime _EndDate {
            get => EndDate;
            set => EndDate = value;
        }

        public double _Salary {
            get => Salary;
            set => Salary = value;
        }

        public string GetFullName() {
            string FullName = this.FirstName + " " + this.LastName;
            return FullName;
        }

        public bool IsActive(DateTime CurrentDate) {
            if(DateTime.Compare(this.EndDate, CurrentDate) > 0 && DateTime.Compare(CurrentDate, this.StartDate) > 0) {
                return true;
            } else {
                return false;
            }
        }

        public abstract string Salutation();
        //We used an abstract method because we needed to implement the method in a different way for both manager and architect classes (virtual methods have an implemetation that can be overriden)
    }
}