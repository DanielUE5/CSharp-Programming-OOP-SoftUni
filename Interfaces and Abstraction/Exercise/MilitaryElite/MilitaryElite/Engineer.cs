using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repair> Repairs { get; }

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<Repair>();
        }

        public void AddRepair(string partName, int hoursWorked) => Repairs.Add(new Repair(partName, hoursWorked));

        public override string ToString()
        {
            var repairsStr = string.Join("\n  ", Repairs.Select(r => r.ToString()));
            return base.ToString() + $"\nCorps: {Corps}\nRepairs:\n  {repairsStr}";
        }
    }
}
