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

    public virtual List<Card> cardDeck { get; private set; }

    public virtual void GenerateDeck()
    {
      cardDeck = Enumerable.Range(1, 4)
      .SelectMany(r => Enumerable.Range(1, 13)
        .Select(c => new Card() // dolt beroende
        {
          rank = (CardRank)r,
          value = (CardValue)c
        }
      )
    )
    .ToList();
    }

    public virtual Card RemoveCard()
    {
      Card card = cardDeck.FirstOrDefault();
      cardDeck.Remove(card);
      return card;
    }

    public void ShuffleCardDeck()
    {
      cardDeck = cardDeck.OrderBy(c => Guid.NewGuid()).ToList();
    }
  }
}