using System;
using System.Collections.Generic;
using System.Linq;

namespace Tagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> database = new List<User>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                else
                {
                    string[] parts = input.Split(new string[] {" -> ", " "}, StringSplitOptions.RemoveEmptyEntries);
                    if (parts[0] == "ban")
                    {
                        int index = database.FindIndex(x => x.Name == parts[1]);
                        database.RemoveAt(index);
                    }
                    else
                    {
                        if (database.Any(x => x.Name == parts[0]))
                        {
                            int index = database.FindIndex(x => x.Name == parts[0]);
                            if (database[index].TagsPoints.ContainsKey(parts[1]))
                                database[index].TagsPoints[parts[1]] += int.Parse(parts[2]);
                            else database[index].TagsPoints.Add(parts[1], int.Parse(parts[2]));
                        }
                        else
                        {
                            User username = new User(parts[0], new Dictionary<string, int>());
                            username.TagsPoints.Add(parts[1], int.Parse(parts[2]));
                            database.Add(username);
                        }
                    }
                }
            }
            foreach (User name in database.OrderByDescending(x => x.TagsPoints.Sum(k => k.Value))
                .ThenBy(x => x.TagsPoints.Count))
            {
                Console.WriteLine(name.Name);
                foreach (var kvp in name.TagsPoints)
                {
                    Console.WriteLine($"- {kvp.Key}: {kvp.Value}");
                }
            }
            Console.ReadLine();
        }
    }
    class User
    {
        public string Name { get; set; }
        public Dictionary<string, int> TagsPoints { get; set; }
        public User(string n, Dictionary<string, int> tp)
        {
            Name = n;
            TagsPoints = tp;
        }
    }
}
