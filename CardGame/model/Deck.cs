using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.model
{
  public class Deck
  {
    public Deck(CardFactory factory)
    {
      GenerateDeck(factory);
    }

    public virtual List<Card> cardDeck { get; private set; }

    public virtual void GenerateDeck(CardFactory factory)
    {
      foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
      {
        foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
        {
          cardDeck.Add(factory.CreateCard(rank, value));
        }
      }
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