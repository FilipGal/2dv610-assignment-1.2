using System;

namespace CardGame.model
{
  public class Game
  {
    public void StartGame()
    {
      CardFactory factory = new CardFactory();
      Deck deck = new Deck(factory);
      deck.GenerateDeck(factory);
    }
  }
}
