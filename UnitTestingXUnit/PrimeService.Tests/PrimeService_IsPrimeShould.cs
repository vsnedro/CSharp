using System;
using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
            Console.WriteLine("PrimeService_IsPrimeShould()");
        }

        #region Sample_Test
        [Fact]
        public void IsPrime_ValueIs0_ReturnsFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(0);

            Assert.False(result);
        }

        [Fact]
        public void IsPrime_ValueIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime.");
        }
        #endregion

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValueLessThan2_ReturnsFalse(uint value)
        {
            bool result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime.");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimeNumbersLessThan10_ReturnsTrue(uint value)
        {
            bool result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime.");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_NotPrimeNumbersLessThan10_ReturnsFalse(uint value)
        {
            bool result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime.");
        }
    }
}
