using System;
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
      string actual = "Daniel";
      sut.SetPlayerName(actual);
      string expected = sut.name;

      Assert.Equal(actual, expected);
    }

    [Fact]
    public void PlayerShouldHaveAHand()
    {
      List<Card> expected = new List<Card>();
      var actual = sut.hand;

      Assert.Equal(expected, actual);
    }
  }
}