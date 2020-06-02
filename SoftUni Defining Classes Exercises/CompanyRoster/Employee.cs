using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyRoster
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Employee(string name, decimal salary, string pos, string dep, string email, int age)
        {
            Name = name;
            Salary = salary;
            Position = pos;
            Department = dep;
            Email = email;
            Age = age;
        }
        public Employee()
        {}
        public static void PrintEmployees(Dictionary<string, List<Employee>> department)
        {
            department = department.OrderByDescending(x => x.Value.Average(t => t.Salary))
                .ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine($"Highest Average Salary: {department.First().Key}");
            foreach (Employee staffPerson in department.First().Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine(staffPerson);
            }
        }

        public override string ToString()
        {
            return $"{Name} {Salary:F2} {Email} {Age}";
        }
    }
}
