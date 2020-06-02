using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KarateSrrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int previousIndex = 0;
            int toAdd = 0;
            while (true)
            {
                Match punch = Regex.Match(input, @"(>)(\d+)(?!$)");
                if (punch.Success)
                {
                    string character = punch.Groups[1].Value;
                    int strength = int.Parse(punch.Groups[2].Value);
                    int counter = strength + toAdd;
                    int index = input.IndexOf(character, previousIndex) + 1;
                    while (counter > 0)
                    {
                        try
                        {
                            if (input[index] != '>')
                            {
                                input = input.Remove(index, 1);
                                counter--;
                            }
                            else
                            {
                                toAdd += counter;
                                goto Done;
                            }
                        }
                        catch
                        {
                            goto Break;
                        }
                        
                    }
                    Done:;
                    previousIndex = index;
                }
                else break;
            }
            Break:;
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
