namespace KingsGambit.Interfaces
{
    public interface IKillable
    {
        bool Status { get; }
        void Die();
    }
}
