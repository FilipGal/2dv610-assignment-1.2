using System;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
  public class CardTest
  {
    Card sut;

    public CardTest()
    {
      sut = new Card();
    }

    [Fact]
    public void ShouldGetCardValue()
    {
      int expected = sut.GetCardValue();
      Assert.InRange(expected, 2, 10);
    }

    [Fact]
    public void ShouldSetCardValue()
    {
      int actual = sut.SetCardValue(5);
      int expected = 5;
      Assert.Equal(actual, expected);
    }
  }
}