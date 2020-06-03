using System;
using KingsGambit.Interfaces;

namespace KingsGambit.Models
{
    public class RoyalGuard : IObserver, IKillable
    {
        private bool dead;
        public string Name { get; private set; }
        public bool Status
        {
            get => dead;
            private set => dead = value;
        }

        public RoyalGuard(string name)
        {
            Name = name;
            Status = false;
        }

        public void Call()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }

        public void Die()
        {
            Status = true;
        }
    }
}
