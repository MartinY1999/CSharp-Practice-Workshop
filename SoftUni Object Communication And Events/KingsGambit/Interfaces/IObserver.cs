namespace KingsGambit.Interfaces
{
    public interface IObserver
    {
        string Name { get; }
        void Call();
    }
}
