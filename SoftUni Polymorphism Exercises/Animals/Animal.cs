namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; }
        public string FavouriteFood { get; }

        public Animal(string name, string food)
        {
            Name = name;
            FavouriteFood = food;
        }
        public abstract string ExplainSelf();
    }
}
