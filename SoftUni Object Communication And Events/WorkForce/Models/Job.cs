using WorkForce.Interfaces;
using WorkForce.IO;

namespace WorkForce.Models
{
    public class Job : IJob
    {
        private string name;
        private int hoursRequired;
        private IWriter writer;
        public IEmployee Employee { get; }

        public Job(string name, int hoursRequired, IEmployee employee)
        {
            this.name = name;
            this.hoursRequired = hoursRequired;
            Employee = employee;
            writer = new Writer();
        }

        public void Update()
        {
            this.hoursRequired -= Employee.HoursPerWeek;
            if (this.hoursRequired <= 0)
                writer.WriteLine($"Job {this.name} done!");
        }

        public bool Status()
        {
            return this.hoursRequired > 0;
        }

        public override string ToString()
        {
            return $"Job: {this.name} Hours Remaining: {this.hoursRequired}";
        }
    }
}
