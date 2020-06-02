using System;
using System.Linq;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;
        public string FacultyNumber
        {
            get => facultyNumber;
            private set
            {
                if (value.Length < 5 || value.Length > 10 || !value.ToCharArray().All(char.IsLetterOrDigit))
                    throw new ArgumentException("Invalid faculty number!");
                facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }
        public override string ToString()
        {
            StringBuilder buildResult = new StringBuilder();
            buildResult.AppendLine($"First Name: {FirstName}")
                .AppendLine($"Last Name: {LastName}")
                .AppendLine($"Faculty number: {FacultyNumber}");
            return buildResult.ToString().TrimEnd();
        }
        public static Student CreateStudent()
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return new Student(data[0], data[1], data[2]);
        }
    }
}
