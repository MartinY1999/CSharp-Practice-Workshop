using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public List<Person> FirstTeam
        {
            get => this.firstTeam;
        }
        public List<Person> ReserveTeam
        {
            get => this.reserveTeam;
        }
        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }
        public void AddPlayer(Person current)
        {
            if (current.Age < 40) this.firstTeam.Add(current);
            else this.reserveTeam.Add(current);
        }
        public void PrintTeam()
        {
            Console.WriteLine($"First team has {this.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {this.ReserveTeam.Count} players.");
        }
    }
}
