using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; }

        public Private(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";
    }
}
