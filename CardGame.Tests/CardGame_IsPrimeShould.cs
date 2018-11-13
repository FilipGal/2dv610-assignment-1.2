using Xunit;
using CardGame.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly CardGameService _CardGameService;

        public PrimeService_IsPrimeShould()
        {
            _CardGameService = new CardGameService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _CardGameService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}
