using System;
using System.Collections.Generic;

namespace CompanyRoster
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, List<Employee>> departments = new Dictionary<string, List<Employee>>();
            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split();
                Employee current = new Employee();
                if (input.Length == 4)
                {
                    current = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], "n/a", -1);
                }
                else if (input.Length == 5)
                {
                    int value;
                    if (int.TryParse(input[4], out value))
                    {
                        current = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], "n/a",
                            int.Parse(input[4]));
                    }
                    else
                    {
                        current = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4], -1);
                    }
                }
                else
                    current = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4],
                        int.Parse(input[5]));
                if (!departments.ContainsKey(current.Department)) departments.Add(current.Department, new List<Employee>());
                departments[current.Department].Add(current);
            }
            Employee.PrintEmployees(departments);
            Console.ReadLine();
        }
    }
}
