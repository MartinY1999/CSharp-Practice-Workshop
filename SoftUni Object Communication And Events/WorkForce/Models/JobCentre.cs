using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WorkForce.Interfaces;
using WorkForce.IO;

namespace WorkForce.Models
{
    public class JobCentre : ISubject, IEnumerable<IJob>
    {
        private IList<IJob> jobs;
        private IList<IEmployee> employees;

        public JobCentre()
        {
            jobs = new List<IJob>();
            employees = new List<IEmployee>();
        }

        public void AddEmployees(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public IEmployee FindEmployee(string name)
        {
            return this.employees.FirstOrDefault(x => x.Name == name);
        }

        public void Register(IJob observer)
        {
            this.jobs.Add(observer);
            this.employees.Remove(observer.Employee);
        }

        public void Notify()
        {
            foreach (IJob job in this.jobs)
            {
                job.Update();
            }
            RemoveCompletedJobs();
        }

        private void RemoveCompletedJobs()
        {
            this.jobs = this.jobs.Where(x => x.Status() == true).ToList();
        }

        public IEnumerator<IJob> GetEnumerator()
        {
            foreach (IJob job in this.jobs)
            {
                yield return job;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
