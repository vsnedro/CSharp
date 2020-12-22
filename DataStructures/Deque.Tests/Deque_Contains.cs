using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_Contains : TestDeque
    {
        [Fact]
        public void Contains_EmptyDeque_ReturnsFalse()
        {
            var actual = _deque.Contains("1");

            Assert.False(actual);
        }

        [Fact]
        public void Contains_DequeWithValue0PushBack_1ReturnsFalse()
        {
            _deque.PushBack("0");
            var actual = _deque.Contains("1");

            Assert.False(actual);
        }

        [Fact]
        public void Contains_DequeWithValue0PushFront_1ReturnsFalse()
        {
            _deque.PushFront("0");
            var actual = _deque.Contains("1");

            Assert.False(actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void Contains_DequeWithValuesFrom1To10_PushBackValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            var actual = _deque.Contains(length.ToString());

            Assert.True(actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void Contains_DequeWithValuesFrom1To10_PushFrontValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushFront(i.ToString());
            }
            var actual = _deque.Contains(length.ToString());

            Assert.True(actual);
        }
    }
}
