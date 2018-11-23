using System;

namespace CardGame.model
{
  public class CardFactory
  {
    public virtual Card CreateCard(CardRank rank, CardValue value) => new Card(rank, value);
  }
}