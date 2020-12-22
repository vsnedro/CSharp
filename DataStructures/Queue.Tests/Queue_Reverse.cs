using System;
using Xunit;

namespace DataStructures.Tests.Queue
{
    public class Queue_Reverse : TestQueue
    {
        [Fact]
        public void Reverse_EmptyQueue_CountReturns0()
        {
            _queue.Reverse();
            var actual = _queue.Count;

            Assert.Equal(0, actual);
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
        public void Reverse_QueueWithValuesFrom1To10_CountReturnsQueueLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            _queue.Reverse();

            var actual = _queue.Count;

            Assert.Equal(length, actual);
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
        public void Reverse_QueueWithValuesFrom1To10_PeekReturnsLastValue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            _queue.Reverse();

            var actual = _queue.Peek();

            Assert.Equal(length.ToString(), actual);
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
        public void Reverse_QueueWithValuesFrom1To10_EnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            _queue.Reverse();

            int actual = 0;
            foreach (var item in _queue)
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
