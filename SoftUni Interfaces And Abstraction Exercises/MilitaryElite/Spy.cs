using System;
using System.Text;

namespace MilitaryElite
{
    public class Spy : Soldier
    {
        public string CodeNumber { get; private set; }
        public Spy(string id, string firstName, string lastName, string codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
        public static Spy Create(string[] parts)
        {
            return new Spy(parts[1], parts[2], parts[3], parts[4]);
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
                .AppendLine($"Code Number: {this.CodeNumber.TrimStart(new char[] {'0'})}");
            return builder.ToString().TrimEnd();
        }
    }
}
