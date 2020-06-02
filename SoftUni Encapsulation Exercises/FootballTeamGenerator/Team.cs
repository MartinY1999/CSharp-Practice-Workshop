using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }
        public List<Player> Players { get; set; } = new List<Player>();
        public double Rating { get; set; } = 0;
        public void GiveName(string name)
        {
            Name = name;
        }
        public bool SameName(string name)
        {
            if (Name != name)
                throw new ArgumentException($"Team {name} does not exist.");
            return true;
        }
        public void AddPlayers(string[] parts)
        {
            Player current = Player.CreatePlayer(parts);
            Players.Add(current);
        }
        public void RemovePlayers(string teamName, string playerName)
        {
            if (SameName(teamName))
            {
                if (Players.Any(x => x.Name == playerName) == false)
                    throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
                else
                {
                    int index = Players.FindIndex(x => x.Name == playerName);
                    Players.RemoveAt(index);
                }
            }
        }
        public void ShowRating(string teamName)
        {
            if (SameName(teamName))
            {
                Players.ForEach(x => Rating += x.Skill);
                Console.WriteLine($"{teamName} - {Rating}");
            }
        }
    }
}
