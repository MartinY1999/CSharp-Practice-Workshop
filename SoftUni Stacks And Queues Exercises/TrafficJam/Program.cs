using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int count = 0;
            while (true)
            {
                string model = Console.ReadLine();
                if (model == "end") break;
                else if (model == "green")
                {
                    for (int i = 1; i <= N; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                        else break;
                    }
                }
                else cars.Enqueue(model);
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
            Console.ReadLine();
        }
    }
}
