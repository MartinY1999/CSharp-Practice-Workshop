using System;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Robot : ICreature
    {
        public string Model { get; set; }
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
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
        public static Robot Create(string[] parts)
        {
            return new Robot(parts[0], parts[1]);
        }
    }
}
