using WorkForce.Factories;
using WorkForce.Interfaces;
using WorkForce.IO;
using WorkForce.Models;

namespace WorkForce.Controller
{
    public class Executioner
    {
        private JobFactory jobFactory;
        private EmployeeFactory employeeFactory;
        private IWriter writer;

        public Executioner(JobFactory jobFactory,
            EmployeeFactory employeeFactory, IWriter writer)
        {
            this.jobFactory = jobFactory;
            this.employeeFactory = employeeFactory;
            this.writer = writer;
        }

        public void CreateEmployee(JobCentre centre, string[] parts)
        {
            string type = parts[0];
            string name = parts[1];
            IEmployee current = employeeFactory.Create(type, name);
            centre.AddEmployees(current);
        }

        public void CreateJob(JobCentre centre, string[] parts)
        {
            string nameOfJob = parts[0];
            int hours = int.Parse(parts[1]);
            string nameOfEmployee = parts[2];
            IJob current = jobFactory.Create(nameOfJob, hours
                , centre.FindEmployee(nameOfEmployee));
            centre.Register(current);
        }

        public void PassWeek(JobCentre centre)
        {
            centre.Notify();
        }

        public void PrintStatus(JobCentre centre)
        {
            foreach (IJob job in centre)
            {
                writer.WriteLine(job);
            }
        }
    }
}
