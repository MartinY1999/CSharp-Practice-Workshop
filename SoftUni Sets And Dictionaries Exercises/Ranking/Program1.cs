using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Contest> contests = new HashSet<Contest>();
            contests = AllContests(contests);
            List<User> users = new List<User>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of submissions") break;
                else
                {
                    string[] parts = Regex.Split(input, "=>");
                    string contest = parts[0];
                    string password = parts[1];
                    string user = parts[2];
                    int points = int.Parse(parts[3]);
                    if (contests.Any(x => x.Name == contest && x.Password == password))
                    {
                        if (users.Any(x => x.Name == user))
                        {
                            int index = users.FindIndex(x => x.Name == user);
                            if (!users[index].ContestPoints.ContainsKey(contest))
                                users[index].ContestPoints.Add(contest, points);
                            else
                            {
                                if (points > users[index].ContestPoints[contest])
                                    users[index].ContestPoints[contest] = points;
                            }
                        }
                        else users.Add(User.ParseData(parts));
                    }
                }
            }
            users = users.OrderByDescending(x => x.ContestPoints.Sum(t => t.Value)).ToList();
            Console.WriteLine(
                $"Best candidate is {users.First().Name} with total {users.First().ContestPoints.Sum(t => t.Value)} points.");
            Console.WriteLine("Ranking:");
            foreach (User username in users.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{username.Name}");
                foreach (var pair in username.ContestPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
            Console.ReadLine();
        }
        static HashSet<Contest> AllContests(HashSet<Contest> contest)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests") break;
                else
                {
                    string[] parts = input.Split(':');
                    Contest current = new Contest(parts[0], parts[1]);
                    contest.Add(current);
                }
            }
            return contest;
        }
    }

    class Contest
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Contest(string n, string p)
        {
            Name = n;
            Password = p;
        }
    }

    class User
    {
        public string Name { get; set; }
        public Dictionary<string, int> ContestPoints { get; set; }
        public User(string n, Dictionary<string, int> c)
        {
            Name = n;
            ContestPoints = c;
        }
        public static User ParseData(string[] input)
        {
            string name = input[2];
            int points = int.Parse(input[3]);
            string contest = input[0];
            return new User(name, new Dictionary<string, int>()
            {
                {contest, points}
            });
        }
    }
}
