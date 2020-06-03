using System;

namespace CardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller.CardGame game = new Controller.CardGame();
            game.Run();
            Console.ReadLine();
        }
    }
}
