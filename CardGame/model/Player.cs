using System;
using System.Collections.Generic;

namespace CardGame.model
{
  public class Player : IPlayer
  {
    public virtual List<Card> hand { get; set; }

    public Player()
    {
      hand = new List<Card>();
    }

    public virtual string name { get; set; }

    public virtual void Hit(Card card) => hand.Add(card);
  }
}
