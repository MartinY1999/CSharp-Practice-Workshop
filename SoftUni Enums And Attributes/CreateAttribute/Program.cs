using System;

namespace CreateAttribute
{
    [SU("Ventsi")]
    public class Program
    {
        [SU("Gosho")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
            Console.ReadLine();
        }
    }
}
