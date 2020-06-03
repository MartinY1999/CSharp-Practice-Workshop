using System;
using System.Collections.Generic;
using System.Linq;
using KingsGambit.Interfaces;
using KingsGambit.Models;

namespace KingsGambit
{
    public class KingdomCentre
    {
        private King king;
        private IDictionary<string, Action<string>> functions;

        public KingdomCentre(string kingName, string[] royalGuardsNames, string[] footmenNames)
        {
            this.king = new King(kingName);
            AddServants(royalGuardsNames, footmenNames);
            functions = new Dictionary<string, Action<string>>()
            {
                {"Attack", (s) => king.Notify()},
                {"Kill", delegate(string name)
                {
                    IKillable current = this.king.Observers.First(x => x.Name == name) as IKillable;
                    current?.Die();
                    this.king.RemoveDeadServants();
                }}
            };
        }

        private void AddServants(string[] royalGuardsNames, string[] footmenNames)
        {
            foreach (string name in royalGuardsNames)
            {
                this.king.Register(new RoyalGuard(name));
            }
            foreach (string name in footmenNames)
            {
                this.king.Register(new Footman(name));
            }
        }

        public void Execute(string[] parts)
        {
            functions[parts[0]].Invoke(parts[1]);
        }
    }
}
