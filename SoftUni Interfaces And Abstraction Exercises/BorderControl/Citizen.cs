using System;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Citizen : ICreature
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public bool TestFakeId(string fakeId)
        {
            StringBuilder toCompare = new StringBuilder();
            toCompare.Append(this.Id, this.Id.Length - fakeId.Length, fakeId.Length);
            if (fakeId == toCompare.ToString())
                return true;
            else
                return false;
        }
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public static Citizen Create(string[] parts)
        {
            return new Citizen(parts[0], int.Parse(parts[1]), parts[2]);
        }
    }
}
