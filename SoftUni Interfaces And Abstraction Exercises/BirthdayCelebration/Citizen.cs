using System;

namespace BirthdayCelebration
{
    public class Citizen : IBirthday
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public DateTime BirthDate { get; set; }
        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
        }
        public static Citizen Create(string[] parts, DateTime time)
        {
            return new Citizen(parts[1], int.Parse(parts[2]), parts[3], time);
        }
    }
}
