using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ParseURLs
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            bool checkValid = Validation(url);
            if (checkValid)
            {
                List<string> splitted = url.Split(new char[] {' ', '/', ':'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                Console.WriteLine($"Protocol = {splitted[0]}");
                Console.WriteLine($"Server = {splitted[1]}");
                Console.WriteLine($"Resources = {String.Join("/", splitted.Skip(2))}");
            }
            else Console.WriteLine("Invalid URL");
            Console.ReadLine();
        }
        private static bool Validation(string url)
        {
            int index = 0;
            int counter = 0;
            while (index != -1)
            {
                if (url.Contains("://"))
                {
                    index = url.IndexOf("://", index);
                    if (index != -1)
                    {
                        index++;
                        counter++;
                    }
                }
            }
            if (counter == 1) return true;
            else return false;
        }
    }
}
