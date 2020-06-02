using System;
using System.Linq;

namespace Mankind
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get => firstName;
            protected set
            {
                if (char.IsLower(value.First()))
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                if (value.Length <= 3 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            protected set
            {
                if (char.IsLower(value.First()))
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                if (value.Length <= 2 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                lastName = value;
            }
        }
        protected Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
