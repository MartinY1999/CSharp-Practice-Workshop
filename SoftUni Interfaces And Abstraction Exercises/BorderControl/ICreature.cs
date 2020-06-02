namespace BorderControl
{
    public interface ICreature
    {
        string Id { get; set; }
        bool TestFakeId(string fakeId);
    }
}
