using MilitaryElite;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var soldiers = new List<ISoldier>();

        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            var tokens = line.Split();

            if (tokens[0] == "Private")
            {
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);
                soldiers.Add(new Private(id, firstName, lastName, salary));
            }
            else if (tokens[0] == "LieutenantGeneral")
            {
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);

                var lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                for (int i = 5; i < tokens.Length; i++)
                {
                    var privateSoldier = soldiers.OfType<Private>().FirstOrDefault(p => p.Id == int.Parse(tokens[i]));
                    if (privateSoldier != null)
                    {
                        lieutenantGeneral.AddPrivate(privateSoldier);
                    }
                }
                soldiers.Add(lieutenantGeneral);
            }
            else if (tokens[0] == "Engineer")
            {
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);
                string corps = tokens[5];

                if (corps != "Airforces" && corps != "Marines") continue;

                var engineer = new Engineer(id, firstName, lastName, salary, corps);
                for (int i = 6; i < tokens.Length; i += 2)
                {
                    string partName = tokens[i];
                    int hoursWorked = int.Parse(tokens[i + 1]);
                    engineer.AddRepair(partName, hoursWorked);
                }
                soldiers.Add(engineer);
            }
            else if (tokens[0] == "Commando")
            {
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);
                string corps = tokens[5];

                if (corps != "Airforces" && corps != "Marines") continue;

                var commando = new Commando(id, firstName, lastName, salary, corps);
                for (int i = 6; i < tokens.Length; i += 2)
                {
                    string codeName = tokens[i];
                    string state = tokens[i + 1];
                    if (state != "inProgress" && state != "Finished") continue;
                    var mission = new Mission(codeName, state);
                    commando.AddMission(mission);
                }
                soldiers.Add(commando);
            }
            else if (tokens[0] == "Spy")
            {
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];
                int codeNumber = int.Parse(tokens[4]);
                soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
            }
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier.ToString());
        }
    }
}