using System;
using System.Collections.Generic;

namespace CardGame.model
{
  public class Card : ICard<CardValue, CardRank>
  {
    public virtual CardRank rank { get; set; }
    public virtual CardValue value { get; set; }

    public Card(CardRank Rank, CardValue Value)
    {
      rank = Rank;
      value = Value;
    }
  }
}