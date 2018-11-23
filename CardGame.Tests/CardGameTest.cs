using Xunit;
using Moq;
using CardGame.model;

namespace CardGame.Tests
{
    public class CardGameTest
    {
        Game sut;

        public CardGameTest()
        {
            sut = new Game();
        }

        [Fact]
        public void GameHasPlayerAndDealer()
        {
            var fakeDealer = new Mock<Dealer>();
            var fakePlayer = new Mock<Player>();

            Player player = fakePlayer.Object;
            Dealer dealer = fakeDealer.Object;

            sut.CreateGame(player, dealer);

            bool playerExists = sut.player != null;
            bool dealerExists = sut.dealer != null;
            
            Assert.True(playerExists);
            Assert.True(dealerExists);
        }
    }
}
