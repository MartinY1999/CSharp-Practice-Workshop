using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get => this.members;
            set => this.members = value;
        }
        public void AddMembers(Person member)
        {
            this.Members.Add(member);
        }
        public static Person GetOldestMember(Family family)
        {
            List<Person> members = new List<Person>();
            foreach (Person person in family.Members)
            {
                members.Add(person);
            }
            int maxAge = members.Max(x => x.Age);
            int index = members.FindIndex(x => x.Age == maxAge);
            return members[index];
        }
    }
}
