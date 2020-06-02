namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Group { get; private set; }
        public int Food { get; private set; }
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public static Rebel Create(string[] parts)
        {
            return new Rebel(parts[0], int.Parse(parts[1]), parts[2]);
        }
        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
