using CardGame.Commands;
using CardGame.Models;

namespace CardGame.Controller
{
    public class CardGame
    {
        public void Run()
        {
            Player first = Executioner.PlayerCreate();
            Player second = Executioner.PlayerCreate();
            Deck deck = new Deck();
            Executioner.AddCards(first, deck);
            Executioner.AddCards(second, deck);
            Executioner.GetWinner(first, second);
        }
    }
}
