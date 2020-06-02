using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpinionPoll
{
    public class Members
    {
        private List<Person> members = new List<Person>();
        public List<Person> Collection
        {
            get => this.members;
            set => this.members = value;
        }
        public void AddMembers(Person member)
        {
            Collection.Add(member);
        }
        public static List<Person> ReturnOver30(Members family)
        {
            List<Person> persons = new List<Person>();
            persons.AddRange(family.Collection);
            return persons.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }
    }
}
