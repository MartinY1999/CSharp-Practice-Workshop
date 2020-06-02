using System;
using System.Globalization;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public DateTime Birthdate { get; private set; }
        public int Food { get; private set; }
        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
        public static Citizen Create(string[] parts)
        {
            return new Citizen(parts[0], int.Parse(parts[1]), parts[2],
                DateTime.ParseExact(parts[3], "dd/MM/yyyy", CultureInfo.InvariantCulture));
        }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
