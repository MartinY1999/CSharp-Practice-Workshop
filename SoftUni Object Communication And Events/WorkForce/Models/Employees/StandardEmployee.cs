using WorkForce.Interfaces;

namespace WorkForce.Models.Employees
{
    public class StandardEmployee : IEmployee
    {
        public string Name { get; private set; }
        public int HoursPerWeek { get; }

        public StandardEmployee(string name)
        {
            Name = name;
            HoursPerWeek = 40;
        }
    }
}
