using System;
using System.Collections.Generic;
using WorkForce.Interfaces;
using WorkForce.Models.Employees;

namespace WorkForce.Factories
{
    public class EmployeeFactory
    {
        private readonly IDictionary<string, Func<string, IEmployee>> returnEmployee;

        public EmployeeFactory()
        {
            this.returnEmployee =
                new Dictionary<string, Func<string, IEmployee>>()
                {
                    {"StandardEmployee", name => new StandardEmployee(name)},
                    {"PartTimeEmployee", name => new PartTimeEmployee(name)}
                };
        }

        public IEmployee Create(string type, string name)
        {
            return this.returnEmployee[type].Invoke(name);
        }
    }
}
