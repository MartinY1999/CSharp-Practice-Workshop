using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier
    {
        public List<Mission> Missions { get; private set; }
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<Mission>();
        }
        public static Commando Create(string[] parts)
        {
            Commando current = new Commando(parts[1], parts[2], parts[3], decimal.Parse(parts[4]), parts[5]);
            current.AddMissions(parts);
            return current;
        }
        private void AddMissions(string[] parts)
        {
            for (int i = 6; i < parts.Length; i+= 2)
            {
                try
                {
                    this.Missions.Add(Mission.Create(parts[i], parts[i + 1]));
                }
                catch
                {
                    continue;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}")
                .AppendLine($"Corps: {this.Corps}")
                .AppendLine("Missions:");
            foreach (Mission mission in this.Missions)
            {
                builder.AppendLine($"  {mission}");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
