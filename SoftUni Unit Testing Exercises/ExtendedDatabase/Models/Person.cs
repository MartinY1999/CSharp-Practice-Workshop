using ExtendedDatabase.Interfaces;

namespace ExtendedDatabase.Models
{
    public class Person : IPerson
    {
        public long Id { get; private set; }
        public string Username { get; private set; }

        public Person(long id, string username)
        {
            Id = id;
            Username = username;
        }
    }
}
