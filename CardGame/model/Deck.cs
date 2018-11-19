using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.model
{
  public class Deck
  {
    public Deck()
    {
      GenerateDeck();
    }

    public List<Card> cardDeck { get; private set; }

    public List<Card> GenerateDeck()
    {
      return cardDeck = Enumerable.Range(1, 4)
      .SelectMany(r => Enumerable.Range(1, 13)
        .Select(c => new Card()
        {
          rank = (CardRank)r,
          value = (CardValue)c
        }
      )
    )
    .ToList();
    }
  }
}