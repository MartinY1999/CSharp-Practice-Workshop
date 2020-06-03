namespace InfernoInfinity.Interfaces
{
    public interface IWeapon
    {
        string Name { get; }
        int MinDamage { get; }
        int MaxDamage { get; }
        IGem[] Sockets { get; }
        void CombineGems();
    }
}
