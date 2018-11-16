using System;
using System.Collections.Generic;

namespace CardGame.model
{
  public class Card
  {

    public int value { get; set; }

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