using System;

namespace BirthdayCelebration
{
    public class Pet : IBirthday
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Pet(string name, DateTime birthday)
        {
            Name = name;
            BirthDate = birthday;
        }
        public static Pet Create(string[] parts, DateTime time)
        {
            return new Pet(parts[1], time);
        }
    }
}
