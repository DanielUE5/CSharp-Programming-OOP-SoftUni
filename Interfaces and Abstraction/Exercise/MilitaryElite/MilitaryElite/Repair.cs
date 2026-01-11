using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Repair
    {
        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public override string ToString() => $"Part Name: {PartName} Hours Worked: {HoursWorked}";
    }
}
