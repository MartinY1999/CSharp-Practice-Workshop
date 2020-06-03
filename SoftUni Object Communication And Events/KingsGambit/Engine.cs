using System;

namespace KingsGambit
{
    public class Engine
    {
        public void Run()
        {
            string kingName = Console.ReadLine();
            string[] royalGuardsNames = Console.ReadLine().Split(' ');
            string[] footmenNames = Console.ReadLine().Split(' ');

            KingdomCentre centre = new KingdomCentre(kingName, royalGuardsNames, footmenNames);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                    break;
                else
                    centre.Execute(input.Split(' '));
            }
        }
    }
}
