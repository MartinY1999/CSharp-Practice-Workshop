using System;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            int N = reader.ReadInt();
            Box<double> box = new Box<double>();
            for (int i = 1; i <= N; i++)
            {
                box.Add(reader.ReadDouble());
            }

            box.CompareValues(reader.ReadDouble());
            Console.WriteLine(box.Count());
            Console.ReadLine();
        }
    }
}
