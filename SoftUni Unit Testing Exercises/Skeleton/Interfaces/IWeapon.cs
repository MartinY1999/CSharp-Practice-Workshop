namespace Skeleton.Interfaces
{
    public interface IWeapon
    {
        int AttackPoints { get; }
        int DurabilityPoints { get; set; }
        void Attack(ITarget target);
    }
}
