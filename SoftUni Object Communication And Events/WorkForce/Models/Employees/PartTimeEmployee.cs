using WorkForce.Interfaces;

namespace WorkForce.Models.Employees
{
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; }
        public int HoursPerWeek { get; }

        public PartTimeEmployee(string name)
        {
            Name = name;
            HoursPerWeek = 20;
        }
    }
}
