using NUnit.Framework;
using Fibonacci.Services;

namespace Fibonacci.Tests.Services
{
    public class Tests
    {
        private FibonacciService _fibonacciService;

        [SetUp]
        public void Setup()
        {
            _fibonacciService = new FibonacciService();
        }

        [Test]
        public void GetFibonacciNumber_ValueIs0_Returns0()
        {
            var expected = 0;
            var actual = _fibonacciService.GetFibonacciNumber(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFibonacciNumber_ValueIs1_Returns1()
        {
            var expected = 1;
            var actual = _fibonacciService.GetFibonacciNumber(1);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        [TestCase(9, 34)]
        [TestCase(10, 55)]
        public void GetFibonacciNumber_ValuesFrom2To10_ReturnsResult(int n, int expected)
        {
            var actual = _fibonacciService.GetFibonacciNumber(n);

            Assert.AreEqual(expected, actual);
        }
    }
}