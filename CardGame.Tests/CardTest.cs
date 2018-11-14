using System;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
  public class CardTest
  {
    [Fact]
    public void ShouldGetCardValue()
    {
      Card sut = new Card();
      int expected = sut.GetCardValue();
      Assert.InRange(expected, 2, 10);
    }
  }
}