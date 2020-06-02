using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weather> weathers = new List<Weather>();
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                else
                {
                    Match result = Regex.Match(input, pattern);
                    if (result.Success)
                    {
                        string name = result.Groups[1].Value;
                        string averageTemp = result.Groups[2].Value;
                        string type = result.Groups[3].Value;
                        if (weathers.Any(x => x.Name == name) == false)
                        {
                            Weather newW = new Weather(name, double.Parse(averageTemp), type);
                            weathers.Add(newW);
                        }
                        else
                        {
                            int index = weathers.FindIndex(x => x.Name == name);
                            if (weathers[index].Temperature == double.Parse(averageTemp))
                            {
                                if (weathers[index].Type == type) continue;
                                else weathers[index].Type = type;
                            }
                            else
                            {
                                weathers[index].Temperature = double.Parse(averageTemp);
                                weathers[index].Type = type;
                            }
                        }
                    }
                }
            }
            foreach (Weather w in weathers.OrderBy(x => x.Temperature))
            {
                Console.WriteLine($"{w.Name} => {w.Temperature:F2} => {w.Type}");
            }
        }
    }
    class Weather
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public string Type { get; set; }
        public Weather(string n, double temp, string type)
        {
            Name = n;
            Temperature = temp;
            Type = type;
        }
    }
}
