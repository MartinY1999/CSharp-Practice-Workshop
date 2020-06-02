using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Company
    {
        public string Name = string.Empty;
        public string Department = string.Empty;
        public string Salary = string.Empty;
        public Company() { }
        public Company(string n, string d, string s)
        {
            Name = n;
            Department = d;
            Salary = s;
        }
    }
}
