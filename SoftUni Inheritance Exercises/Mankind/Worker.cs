using System;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weeklySalary;
        private int hours;
        public decimal WeeklySalary
        {
            get => weeklySalary;
            private set
            {
                if (value > 10)
                    weeklySalary = value;
                else
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
        }
        public int Hours
        {
            get => hours;
            private set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                hours = value;
            }
        }
        public decimal SalaryPerHour => GetSalaryPerHour();
        public Worker(string firstName, string lastName, decimal salary, int hours) : base(firstName, lastName)
        {
            WeeklySalary = salary;
            Hours = hours;
        }
        private decimal GetSalaryPerHour()
        {
            return WeeklySalary / (Hours * 5);
        }
        public override string ToString()
        {
            StringBuilder buildResult = new StringBuilder();
            buildResult.AppendLine($"First Name: {FirstName}")
                .AppendLine($"Last Name: {LastName}")
                .AppendLine($"Week Salary: {WeeklySalary:F2}")
                .AppendLine($"Hours per day: {Hours:F2}")
                .AppendLine($"Salary per hour: {SalaryPerHour:F2}");
            return buildResult.ToString().TrimEnd();
        }
        public static Worker CreateWorker()
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return new Worker(data[0], data[1], decimal.Parse(data[2]), int.Parse(data[3]));
        }
    }
}
