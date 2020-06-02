using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier
    {
        public List<Repair> Repairs { get; private set; }
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<Repair>();
        }
        public static Engineer Create(string[] parts)
        {
            Engineer current = new Engineer(parts[1], parts[2], parts[3], decimal.Parse(parts[4]), parts[5]);
            current.RepairParts(parts);
            return current;
        }
        private void RepairParts(string[] parts)
        {
            for (int i = 6; i < parts.Length; i += 2)
            {
                try
                {
                    this.Repairs.Add(Repair.Create(parts[i], parts[i + 1]));
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
                .AppendLine($"Repairs:");
            foreach (Repair repair in this.Repairs)
            {
                builder.AppendLine($"  {repair}");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
