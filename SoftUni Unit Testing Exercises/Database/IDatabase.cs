namespace Database
{
    public interface IDatabase
    {
        int?[] Integers { get; }
        void Add(int element);
        void Remove();
        int?[] Fetch();
    }
}
