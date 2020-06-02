using System;

namespace MordorsCruelPlan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gandalf gandalf = new Gandalf();
            gandalf.GetMood();
            Console.WriteLine(gandalf.Points);
            Console.WriteLine(gandalf.Mood);
            Console.ReadLine();
        }
    }
}
