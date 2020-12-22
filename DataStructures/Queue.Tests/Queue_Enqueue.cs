using System;
using Xunit;

namespace DataStructures.Tests.Queue
{
    public class Queue_Enqueue : TestQueue
    {
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
        public void Enqueue_ValuesFrom1To10_CountReturnsQueueLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }

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
        public void Enqueue_ValuesFrom1To10_EnumeratorReturnsQueueLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }

            int actual = 0;
            foreach (var item in _queue)
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
