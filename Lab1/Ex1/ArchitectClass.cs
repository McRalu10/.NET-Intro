using System;

namespace ArchitectClass
{
    public class Architect
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
    }
}