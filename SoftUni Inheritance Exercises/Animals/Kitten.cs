namespace Animals
{
    public class Kitten : Animals
    {
        public Kitten(string name, int age) : base(name, age, "Female")
        {
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
