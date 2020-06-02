using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public abstract class SpecialisedSoldier : Soldier, ICorps
    {
        private string corps;
        public decimal Salary { get; private set; }
        public string Corps
        {
            get => corps;
            private set
            {
                if (value == "Airforces" || value == "Marines")
                    corps = value;
                else
                    throw new ArgumentException("");
            }
        }
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName)
        {
            Salary = salary;
            Corps = corps;
        }
    }
}
