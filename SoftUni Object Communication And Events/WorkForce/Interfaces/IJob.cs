namespace WorkForce.Interfaces
{
    public interface IJob
    {
        IEmployee Employee { get; }
        void Update();
        bool Status();
    }
}