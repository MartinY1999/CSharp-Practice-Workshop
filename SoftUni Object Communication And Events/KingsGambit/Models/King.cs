using System;
using System.Collections.Generic;
using System.Linq;
using KingsGambit.Interfaces;

namespace KingsGambit.Models
{
    public class King : ISubject, IAttackable
    {
        public string Name { get; private set; }
        public List<IObserver> Observers { get; private set; }

        public King(string name)
        {
            Observers = new List<IObserver>();
            Name = name;
        }

        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            this.GetAttacked();
            foreach (IObserver observer in Observers)
            {
                observer.Call();
            }
        }

        public void GetAttacked()
        {
            Console.WriteLine($"King {Name} is under attack!");
        }

        public void RemoveDeadServants()
        {
            for (int i = 0; i < Observers.Count; i++)
            {
                IKillable current = Observers[i] as IKillable;
                if (current?.Status == true)
                {
                    Observers.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
