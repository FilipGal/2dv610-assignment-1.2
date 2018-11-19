using System;
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
  }
}