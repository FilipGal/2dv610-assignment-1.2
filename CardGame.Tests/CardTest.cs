using System;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
  public class CardTest
  {
    Card sut;
    CardRank rank = CardRank.Diamonds;
    CardValue value = CardValue.Ace;

    public CardTest()
    {
      sut = new Card(rank, value);
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