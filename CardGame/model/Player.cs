using System;
using System.Collections.Generic;

namespace CardGame.model
{
  public class Player : IPlayer
  {
    public virtual string name { get; set; }

    public List<Card> hand = new List<Card>();
  }
}