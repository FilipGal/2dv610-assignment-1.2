using System;
using System.Collections.Generic;

namespace CardGame.model
{
  public class Card
  {

    public CardValue value { get; set; }
    public int rank { get; set; }
    private int cardValue = 5;

    public int GetCardValue()
    {
      return cardValue;
    }
    public int SetCardValue(int value)
    {
      return cardValue = value;
    }
  }
}