using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P02_BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type blackBoxClass = typeof(BlackBoxInteger);
            BlackBoxInteger box = (BlackBoxInteger)Activator.CreateInstance(blackBoxClass, true);
          
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;
                else
                {
                    string command = input.Split('_')[0];
                    int number = int.Parse(input.Split('_')[1]);
                    blackBoxClass.GetMethod(command, BindingFlags.Instance |
                                                     BindingFlags.NonPublic)
                        .Invoke(box, new object[] {number});
                    int result = (int)blackBoxClass.GetField("innerValue", BindingFlags.Instance |
                                                                      BindingFlags.NonPublic).GetValue(box);
                    Console.WriteLine(result);
                }
            }
            Console.ReadLine();
        }
    }
}
