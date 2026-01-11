using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public interface ICommando : ISpecialisedSoldier
    {
        List<Mission> Missions { get; }
    }
}
