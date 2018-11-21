using System;
using System.Collections.Generic;

namespace CardGame.model
{
  public class Card : ICard<CardValue, CardRank>
  {

    public virtual CardValue value { get; set; }
    public virtual CardRank rank { get; set; }
  }
}