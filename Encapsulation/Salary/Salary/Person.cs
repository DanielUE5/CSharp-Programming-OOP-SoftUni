using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public void IncreaseSalary(decimal percentage)
        {
            decimal salaryIncrease = Salary * percentage / 100;
            if (this.Age <= 30)
            {
                salaryIncrease /= 2;
            }

            Salary += salaryIncrease;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
       
