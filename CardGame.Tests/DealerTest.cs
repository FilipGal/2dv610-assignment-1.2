using System;
using Moq;
using System.Collections.Generic;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
  public class DealerTest
  {
    Dealer sut;

    public DealerTest()
    {
      sut = new Dealer();
    }

    [Fact]
    public void DealerHasPropertyName()
    {
      string expected = "Dealer";
      string actual = sut.name;
      Assert.Equal(expected, actual);
    }
  }
}