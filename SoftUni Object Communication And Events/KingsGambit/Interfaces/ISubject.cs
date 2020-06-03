namespace KingsGambit.Interfaces
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Notify();
    }
}
