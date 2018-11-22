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
    public PlayerTest()
    {
      sut = new Player();
    }

    // Should be a sut
    [Fact]
    public void ShouldSetPlayerName()
    {
      string name = "spelare1";
      var mock = new Mock<IPlayer>();
      mock.SetupProperty(p => p.name, name);
      IPlayer player = mock.Object;
      string actual = name;
      string expected = player.name;

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
      mock.Setup(d => d.GenerateDeck());
      Deck deck = mock.Object;

      Card card = deck.RemoveCard();
      sut.Hit(card);

      int actual = sut.hand.Count;
      int expected = 1;
      
      Assert.Equal(actual, expected);
    }
  }
}