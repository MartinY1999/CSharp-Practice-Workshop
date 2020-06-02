using System.Reflection.Metadata.Ecma335;

namespace PersonsInfo
{
    public class Person
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int age;
        private decimal salary;
        public string FirstName => firstName;
        public string LastName => lastName;
        public int Age => age;
        public decimal Salary
        {
            get => this.salary;
            set => this.salary = value;
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
        public static Person CreatePerson(string[] input)
        {
            return new Person(input[0], input[1],
                int.Parse(input[2]),
                decimal.Parse(input[3]));
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }
    }
}
