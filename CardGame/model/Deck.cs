using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.model
{
  public class Deck
  {
    public virtual List<Card> cardDeck { get; private set; }

    public virtual void GenerateDeck(CardFactory factory)
    {
      List<Card> card = new List<Card>();
      foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
      {
        foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
        {
          card.Add(factory.CreateCard(rank, value));
        }
      }
      cardDeck = card;
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