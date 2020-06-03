namespace WorkForce.Interfaces
{
    public interface ISubject
    {
        void Register(IJob observer);
        void Notify();
    }
}
