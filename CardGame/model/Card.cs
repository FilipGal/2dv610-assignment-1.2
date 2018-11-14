using System;
using System.Collections.Generic;

namespace CardGame.model
{
  public class Card
  {

    private int cardValue = 2;
    
    public int GetCardValue()
    {
      return cardValue;
    }
    public int SetCardValue(int value)
    {
      throw new NotImplementedException("Not yet implemented");
    }
  }
}