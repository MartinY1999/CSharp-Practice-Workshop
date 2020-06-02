using System;
using System.Collections.Generic;
using System.Linq;

namespace IronGirder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TTP> data = new List<TTP>();
            string[] delimit = { "->", ":" };
            while (true)
            {
                string[] input = Console.ReadLine().Split(delimit, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Slide rule") break;
                else
                {
                    try
                    {
                        TTP current = TTP.ParseData(input);
                        if (data.Any(x => x.Town == current.Town))
                        {
                            int index = data.FindIndex(x => x.Town == current.Town);
                            if (data[index].Time > current.Time || data[index].Time == 0) data[index].Time = current.Time;
                            data[index].Passengers += current.Passengers;
                        }
                        else data.Add(current);
                    }
                    catch
                    {
                        if (input[1] == "ambush")
                        {
                            if (data.Any(x => x.Town == input[0]))
                            {
                                int index = data.FindIndex(x => x.Town == input[0]);
                                data[index].Time = 0;
                                if (data[index].Passengers > int.Parse(input[2]))
                                    data[index].Passengers -= int.Parse(input[2]);
                            }
                        }
                    }
                }
            }

            foreach (TTP ttp in data.OrderBy(x => x.Time).ThenBy(x => x.Town))
            {
                if (ttp.Time != 0 && ttp.Passengers > 0)
                    Console.WriteLine($"{ttp.Town} -> Time: {ttp.Time} -> Passengers: {ttp.Passengers}");
            }

            Console.ReadLine();
        }
    }

    class TTP
    {
        public string Town { get; set; }
        public int Time { get; set; }
        public int Passengers { get; set; }

        public TTP(string t, int tme, int p)
        {
            Town = t;
            Time = tme;
            Passengers = p;
        }
        public static TTP ParseData(string[] input)
        {
            string t = input[0];
            int tme = int.Parse(input[1]);
            int p = int.Parse(input[2]);
            return new TTP(t, tme, p);
        }
    }
}
