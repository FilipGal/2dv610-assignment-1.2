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
      Random rnd = new Random();
      int expected = rnd.Next(2, 10);
      int actual = sut.SetCardValue(expected);
      Assert.Equal(actual, expected);
    }

    [Fact]
    public void CardValueIsCorrectType()
    {
      bool expected = sut.value.GetType().IsEnum;
      Assert.True(expected);
    }

    [Fact]
    public void CardRankIsCorrectType()
    {
      bool expected = sut.rank.GetType().IsEnum;
      Assert.True(expected);
    }
  }
}