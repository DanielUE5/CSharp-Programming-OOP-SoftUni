using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<IPrivate> Privates { get; }

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public void AddPrivate(IPrivate privateSoldier) => Privates.Add(privateSoldier);

        public override string ToString()
        {
            var privatesStr = string.Join("\n  ", Privates.Select(p => p.ToString()));
            return base.ToString() + "\nPrivates:\n  " + privatesStr;
        }
    }
}
