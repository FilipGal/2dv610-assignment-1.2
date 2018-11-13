using Xunit;
using CardGame.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly CardGameService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new CardGameService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}
