using System;
using Xunit;

namespace DataStructures.Tests.Queue
{
    public class Queue_Contains : TestQueue
    {
        [Fact]
        public void Contains_EmptyQueue_ReturnsFalse()
        {
            var actual = _queue.Contains("1");

            Assert.False(actual);
        }

        [Fact]
        public void Contains_QueueWithValue0_1ReturnsFalse()
        {
            _queue.Enqueue("0");
            var actual = _queue.Contains("1");

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
        public void Contains_QueueWithValuesFrom1To10_AddedValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            var actual = _queue.Contains(length.ToString());

            Assert.True(actual);
        }
    }
}
