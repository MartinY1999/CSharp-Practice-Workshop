using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            int N = reader.ReadInt();
            IList<Box<int>> box = new List<Box<int>>();
            for (int i = 1; i <= N; i++)
            {
                box.Add(reader.ReadIntBox());
            }

            IList<int> command = reader.ReadCommand();
            Swap(box, command);
            foreach (var element in box)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
        private static void Swap(IList<Box<int>> box, IList<int> command)
        {
            Box<int> temp = box.ElementAt(command[0]);
            box[command[0]] = box[command[1]];
            box[command[1]] = temp;
        }
    }
}
