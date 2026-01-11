using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<Mission>();
        }

        public void AddMission(Mission mission) => Missions.Add(mission);

        public override string ToString()
        {
            var missionsStr = Missions.Count > 0 ? string.Join("\n  ", Missions.Select(m => m.ToString())) : "";
            return base.ToString() + $"\nCorps: {Corps}\nMissions:{(missionsStr != "" ? "\n  " + missionsStr : "")}";
        }
    }
}
