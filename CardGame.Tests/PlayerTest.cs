using System;
using Moq;
using System.Collections.Generic;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
  public class PlayerTest
  {
    Player sut;
    CardFactory factory;

    public PlayerTest()
    {
      factory = new CardFactory();
      sut = new Player();
    }

    [Fact]
    public void ShouldSetPlayerName()
    {
      string name = "spelare1";
      sut.name = name;

      string actual = sut.name;
      string expected = name;

      Assert.Equal(actual, expected);
    }

    [Fact]
    public void PlayerShouldHaveAHand()
    {
      List<Card> expected = new List<Card>();
      List<Card> actual = sut.hand;
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PlayerShouldRecieveCard()
    {
      var mock = new Mock<Deck>();
      mock.Setup(d => d.GenerateDeck(factory));
      Deck deck = mock.Object;

      Card card = deck.RemoveCard();
      sut.Hit(card);

      int actual = sut.hand.Count;
      int expected = 1;

      Assert.Equal(actual, expected);
    }
  }
}