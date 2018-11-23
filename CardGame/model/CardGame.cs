using System;

namespace CardGame.model
{
  public class Game
  {
    public void StartGame()
    {
      CardFactory factory = new CardFactory();
      Deck deck = new Deck();
      deck.GenerateDeck(factory);
    }
  }
}
