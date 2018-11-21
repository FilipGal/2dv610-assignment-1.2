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
      Card card = new Card();

      var mock = new Mock<IPlayer>();
      mock.Setup(p => p.Hit());
      IPlayer player = mock.Object;
      
      player.Hit();
      bool actual = player.hand.Count > 0;
      Assert.True(actual);
    }
  }
}