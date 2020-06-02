using System;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;
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
        public double Endurance
        {
            get => endurance;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"Endurance should be between 0 and 100.");
                endurance = value;
            }
        }
        public double Sprint
        {
            get => sprint;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"Sprint should be between 0 and 100.");
                sprint = value;
            }
        }
        public double Dribble
        {
            get => dribble;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                dribble = value;
            }
        }
        public double Passing
        {
            get => passing;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"Passing should be between 0 and 100.");
                passing = value;
            }
        }
        public double Shooting
        {
            get => shooting;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"Shooting should be between 0 and 100.");
                shooting = value;
            }
        }
        public double Skill { get; set; }
        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
        public static Player CreatePlayer(string[] parts)
        {
            Player current = new Player(parts[2], double.Parse(parts[3]), 
                double.Parse(parts[4]), double.Parse(parts[5]), 
                double.Parse(parts[6]), double.Parse(parts[7]));
            current.Skill =
                Math.Round((current.Endurance + current.Sprint + current.Dribble + current.Passing + current.Shooting) / 5);
            return current;
        }
    }
}
