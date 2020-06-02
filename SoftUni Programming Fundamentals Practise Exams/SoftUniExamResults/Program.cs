using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            Dictionary<string, double> submissions = new Dictionary<string, double>();
            List<string> banned = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished") break;
                else
                {
                    string[] parts = input.Split('-');
                    if (parts[1] == "banned")
                    {
                        string username = parts[0];
                        if (users.Any(x => x.Username == username))
                        {
                            banned.Add(username);
                            users.RemoveAll(x => x.Username == username);
                        }
                    }
                    else
                    {
                        string username = parts[0];
                        string language = parts[1];
                        double points = double.Parse(parts[2]);
                        if (users.Any(x => x.Username == username))
                        {
                            int index = users.FindIndex(x => x.Username == username);
                            if (users.Any(x => x.Languages.Contains(language)) == false) users[index].Languages.Add(language);
                            if (users[index].Points < points) users[index].Points = points;
                        }
                        else
                        {
                            User current = new User(username, new List<string>(), points);
                            current.Languages.Add(language);
                            users.Add(current);
                        }
                        if (!submissions.ContainsKey(language)) submissions.Add(language, 0);
                        submissions[language]++;
                    }
                }
            }

            Console.WriteLine("Results:");
            foreach (User user in users.OrderByDescending(x => x.Points).ThenBy(x => x.Username))
            {
                Console.WriteLine($"{user.Username} | {user.Points}");
            }
            Console.WriteLine("Submissions:");
            foreach (var pair in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            Console.ReadLine();
        }
    }

    class User
    {
        public string Username { get; set; }
        public List<string> Languages { get; set; }
        public double Points { get; set; }

        public User(string u, List<string> l, double p)
        {
            Username = u;
            Languages = l;
            Points = p;
        }
    }
}
