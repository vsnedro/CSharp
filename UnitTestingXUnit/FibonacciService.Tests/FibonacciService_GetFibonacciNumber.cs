using System;
using Xunit;
using Fibonacci.Services;

namespace Fibonacci.UnitTests.Sevices
{
    public class FibonacciService_GetFibonacciNumber
    {
        private FibonacciService _fibonacciService;

        public FibonacciService_GetFibonacciNumber()
        {
            _fibonacciService = new FibonacciService();
        }

        [Fact]
        public void GetFibonacciNumber_ValueIs0_Returns0()
        {
            uint actual = _fibonacciService.GetFibonacciNumber(0);
            uint expected = 0;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFibonacciNumber_ValueIs1_Returns1()
        {
            uint actual = _fibonacciService.GetFibonacciNumber(1);
            uint expected = 1;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(10, 55)]
        public void GetFibonacciNumbers_ValuesFrom2To10_ReturnsResult(uint n, uint expected)
        {
            uint actual = _fibonacciService.GetFibonacciNumber(n);

            Assert.Equal(expected, actual);
        }
    }
}
