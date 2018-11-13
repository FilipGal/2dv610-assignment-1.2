using Xunit;
using CardGame.Services;

namespace Prime.UnitTests.Services
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
            var result = _CardGame.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}
