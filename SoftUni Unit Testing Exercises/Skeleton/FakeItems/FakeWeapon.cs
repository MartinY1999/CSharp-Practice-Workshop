using System;
using Skeleton.Interfaces;

namespace Skeleton.FakeItems
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 10;
        public int DurabilityPoints { get; set; } = 10;
        public void Attack(ITarget target)
        {
            if (this.DurabilityPoints <= 0)
            {
                throw new InvalidOperationException("Weapon is broken.");
            }

            target.TakeAttack(this.AttackPoints);
            this.DurabilityPoints -= 1;
        }
    }
}
