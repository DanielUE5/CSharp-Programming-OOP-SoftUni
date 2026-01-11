using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Mission
    {
        public string CodeName { get; set; }
        public string State { get; set; }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public void CompleteMission() => State = "Finished";

        public override string ToString() => $"Code Name: {CodeName} State: {State}";
    }
}
