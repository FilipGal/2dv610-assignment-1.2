using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
  public class DeckTest
  {
    Deck sut;

    public DeckTest()
    {
      sut = new Deck();
    }

    [Fact]
    public void DeckIsNotNull()
    {
      sut.GenerateDeck();

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
      sut.ShuffleCardDeck();
      bool actual = notShuffledDeck.cardDeck.SequenceEqual(sut.cardDeck);

      Assert.False(actual);
    }
  }
}