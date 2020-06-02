using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == "END") break;
                    else
                    {
                        string[] parts = input.Split(';');
                        if (teams.Any(x => x.Name == parts[1]))
                        {
                            int index = teams.FindIndex(x => x.Name == parts[1]);
                            CaseActions(parts, teams[index]);
                        }
                        else
                        {
                            Team team = new Team();
                            CaseActions(parts, team);
                            teams.Add(team);
                        }
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            Console.ReadLine();
        }

        private static void CaseActions(string[] parts, Team team)
        {
            switch (parts[0])
            {
                case "Team":
                    team.GiveName(parts[1]);
                    break;
                case "Add":
                    if (team.SameName(parts[1]))
                        team.AddPlayers(parts);
                    break;
                case "Remove":
                    team.RemovePlayers(parts[1], parts[2]);
                    break;
                case "Rating":
                    team.ShowRating(parts[1]);
                    break;
            }
        }
    }
}
