namespace MilitaryElite
{
    public class Private : Soldier
    {
        public decimal Salary { get; private set; }
        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }
        public static Private Create(string[] parts)
        {
            return new Private(parts[1], parts[2], parts[3], decimal.Parse(parts[4]));
        }
        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
        }
    }
}
