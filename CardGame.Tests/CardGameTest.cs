using Xunit;
using CardGame.model;

namespace CardGame.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly Program _CardGame;

        public PrimeService_IsPrimeShould()
        {
            _CardGame = new Program();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _CardGame.Valid("Valid test");
            Assert.False(result, "The string should be 'Valid test'");
        }
    }
}
