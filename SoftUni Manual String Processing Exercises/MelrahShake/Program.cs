using System;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (pattern.Length > 0)
            {
                try
                {
                    int index = characters.IndexOf(pattern);
                    characters = characters.Remove(index, pattern.Length);
                    index = characters.LastIndexOf(pattern);
                    characters = characters.Remove(index, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    int indexToRemove = pattern.Length / 2;
                    pattern = pattern.Remove(indexToRemove, 1);
                }
                catch
                {
                    goto Done;
                }
            }
            Done:;
            Console.WriteLine("No shake.");
            Console.WriteLine(characters);
            Console.ReadLine();
        }
    }
}
