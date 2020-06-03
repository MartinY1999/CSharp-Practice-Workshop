using WorkForce.Interfaces;
using WorkForce.Models;

namespace WorkForce.Factories
{
    public class JobFactory
    {
        public IJob Create(string name, int hoursRequired, IEmployee employee)
        {
            return new Job(name, hoursRequired, employee);
        }
    }
}
