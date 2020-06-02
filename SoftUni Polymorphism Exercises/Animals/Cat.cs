namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string food) :base(name, food) { }
        public override string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}\r\nMEEOW";
        }
    }
}
