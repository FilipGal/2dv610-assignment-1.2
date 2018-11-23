using System;
using Moq;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
  public class DeckTest
  {
    Deck sut;
    CardFactory factory;

    public DeckTest()
    {
      factory = new CardFactory();
      sut = new Deck();
      sut.GenerateDeck(factory); // Inject <Mock object> here
    }

    [Fact]
    public void DeckIsNotNull()
    {
      List<Card> actual = sut.cardDeck;
      Assert.NotNull(actual);
    }

    [Fact]
    public void DeckContainsCorrectAmountOfCards()
    {
      int expected = 52;
      int actual = sut.cardDeck.Count;
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldDecreaseDeckSizeOnDrawnCard()
    {
      int expected = sut.cardDeck.Count - 1;
      sut.RemoveCard();
      int actual = sut.cardDeck.Count;
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void CardDeckShouldBeShuffled()
    {
      Deck notShuffledDeck = new Deck();
      notShuffledDeck.GenerateDeck(factory);
      sut.ShuffleCardDeck();
      bool actual = notShuffledDeck.cardDeck.SequenceEqual(sut.cardDeck);

      Assert.False(actual);
    }
  }
}