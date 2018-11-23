using System;

namespace CardGame.model
{
  public class Game
  {

    public Dealer dealer;
    public Player player;
    
    public void StartGame()
    {
      CardFactory factory = new CardFactory();
      Deck deck = new Deck();
      deck.GenerateDeck(factory);
    }

    public void CreateGame(Player p, Dealer d)
    {
      throw new NotImplementedException("Not yet implemented");
    }
  }
}
