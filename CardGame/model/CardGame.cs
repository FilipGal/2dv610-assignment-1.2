using System;

namespace CardGame.model
{
  public class Game
  {
    public void StartGame()
    {
      Deck deck = new Deck();
      deck.GenerateDeck();
    }
  }
}
