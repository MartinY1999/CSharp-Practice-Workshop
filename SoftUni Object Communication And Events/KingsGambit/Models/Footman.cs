using System;
using KingsGambit.Interfaces;

namespace KingsGambit.Models
{
    public class Footman : IObserver, IKillable
    {
        private bool dead;
        public string Name { get; private set; }
        public bool Status
        {
            get => dead;
            private set => dead = value;
        }

        public Footman(string name)
        {
            Name = name;
            Status = false;
        }

        public void Call()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }

        public void Die()
        {
            Status = true;
        }
    }
}
