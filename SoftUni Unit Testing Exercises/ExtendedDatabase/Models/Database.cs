using System;
using System.Collections.Generic;
using System.Linq;
using ExtendedDatabase.Interfaces;

namespace ExtendedDatabase.Models
{
    public class Database : IDatabase
    {
        private IList<IPerson> people;

        public Database()
        {
            this.people = new List<IPerson>();
        }

        public void Add(IPerson person)
        {
            if (this.people.Any(x => x.Id == person.Id || x.Username == person.Username))
                throw new InvalidOperationException("This person is already in the database.");
            this.people.Add(person);
        }

        public void Remove(string name)
        {
            if (this.people.Count == 0)
                throw new InvalidOperationException("No people.");
            if (this.people.Any(x => x.Username == name))
            {
                this.people.Remove(this.people.First(x => x.Username == name));
            }
        }

        public IPerson FindByID(long id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("ID can't be negative.");
            if (this.people.Any(x => x.Id == id) == false)
                throw new InvalidOperationException("Person is not present.");
            return this.people.First(person => person.Id == id);
        }

        public IPerson FindByUsername(string username)
        {
            if (username == null)
                throw new ArgumentNullException("Given username is null.");
            if (this.people.Any(x => x.Username == username) == false)
                throw new InvalidOperationException("Person is not present.");
            return this.people.First(person => person.Username == username);
        }
    }
}
