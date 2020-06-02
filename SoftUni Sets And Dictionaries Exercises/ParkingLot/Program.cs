using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> ids = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                else
                {
                    string[] split = Regex.Split(input, ", ");
                    string command = split[0];
                    string id = split[1];
                    if (command == "IN") ids.Add(id);
                    else ids.Remove(id);
                }
            }
            Console.WriteLine(ids.Count == 0
                ? "Parking Lot is Empty"
                : String.Join(Environment.NewLine, ids.ToList()));
            Console.ReadLine();
        }
    }
}