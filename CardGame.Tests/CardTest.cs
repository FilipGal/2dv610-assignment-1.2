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
      sut = new Card(CardRank.Diamonds, CardValue.Ace);
    }

    private void CardTypeIsEnum(Enum type)
    {
      bool expected = type.GetType().IsEnum;
      Assert.True(expected);
    }

    [Fact]
    public void CardValueIsCorrectType()
    {
      CardTypeIsEnum(sut.value);
    }
 
    [Fact]
    public void CardRankIsCorrectType()
    {
      CardTypeIsEnum(sut.rank);
    }
  }
}