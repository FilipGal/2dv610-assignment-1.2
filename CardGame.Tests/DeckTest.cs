using System;
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
      List<Card> actual = sut.GenerateDeck();
      Assert.NotNull(actual);
    }
  }
}