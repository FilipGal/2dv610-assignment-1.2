using System;
using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
    public class PlayerTest
    {
        [Fact]
        public void ShouldSetPlayerName()
        {
          Player player = new Player();

          string actual = "Daniel";
          player.SetPlayerName();
          string expected = player.name;

          Assert.Equal(actual, expected);
        }
    }
}