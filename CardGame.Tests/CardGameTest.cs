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

        
        public void GameHasPlayerAndDealer()
        {
            var fakeDealer = new Mock<Dealer>();
            var fakePlayer = new Mock<Player>();

            Player player = fakePlayer.Object;
            Dealer dealer = fakeDealer.Object;

            sut.CreateGame(player, dealer);

            Assert.True(Exists(sut.player));
            Assert.True(Exists(sut.dealer));
        }
        
        public bool Exists(Player player)
        {
            return player != null;
        }
    }
}
