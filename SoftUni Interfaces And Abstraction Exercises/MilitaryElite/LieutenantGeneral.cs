using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Soldier
    {
        public decimal Salary { get; private set; }
        public List<Soldier> Privates { get; private set; }
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
            Privates = new List<Soldier>();
        }
        public static LieutenantGeneral Create(string[] parts, List<Soldier> soldiers)
        {
            LieutenantGeneral current = new LieutenantGeneral(parts[1], parts[2],
                parts[3], decimal.Parse(parts[4]));
            current.AddPrivates(parts, soldiers);
            return current;
        }
        private void AddPrivates(string[] parts, List<Soldier> soldiers)
        {
            for (int i = 5; i < parts.Length; i++)
            {
                if (soldiers.Any(x => x.Id == parts[i]))
                {
                    int index = soldiers.FindIndex(x => x.Id == parts[i]);
                    if (soldiers[index].GetType().ToString() == "MilitaryElite.Private")
                        this.Privates.Add(soldiers[index]);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}")
                .AppendLine("Privates:");
            foreach (var pvate in this.Privates)
            {
                builder.AppendLine($"  {pvate}");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
