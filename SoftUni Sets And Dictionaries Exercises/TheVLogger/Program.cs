using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vlogger = new HashSet<string>();
            List<Vlogger> vloggers = new List<Vlogger>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics") break;
                else
                {
                    string[] parts = input.Split(' ');
                    if (parts.Any(x => x == "joined"))
                    {
                        if (!vloggers.Any(x => x.Name == parts[0])) vloggers.Add(new Vlogger(parts[0], new List<string>(), new List<string>()));
                        vlogger.Add(parts[0]);
                    }
                    else if (parts.Any(x => x == "followed"))
                    {
                        string follower = parts[0];
                        string followed = parts[2];
                        if (follower != followed)
                        {
                            if (vlogger.Contains(follower) && vlogger.Contains(followed))
                            {
                                int index = vloggers.FindIndex(x => x.Name == followed);
                                if (!vloggers[index].Followers.Contains(follower)) vloggers[index].Followers.Add(follower);
                                int anotherIndex = vloggers.FindIndex(x => x.Name == follower);
                                if (!vloggers[anotherIndex].Following.Contains(followed)) vloggers[anotherIndex].Following.Add(followed);
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int counter = 1;
            foreach (Vlogger vl in vloggers.OrderByDescending(x => x.Followers.Count)
                .ThenBy(x => x.Following.Count))
            {
                Console.WriteLine(
                    $"{counter}. {vl.Name} : {vl.Followers.Count} followers, {vl.Following.Count} following");
                if (counter == 1)
                {
                    foreach (string follower in vl.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++;
            }
            Console.ReadLine();
        }
    }

    class Vlogger
    {
        public string Name { get; set; }
        public List<string> Followers { get; set; }
        public List<string> Following { get; set; }

        public Vlogger(string n, List<string> fllwers, List<string> fllwing)
        {
            Name = n;
            Followers = fllwers;
            Following = fllwing;
        }
    }
}
