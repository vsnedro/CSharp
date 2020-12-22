using System;
using Xunit;

namespace DataStructures.Tests.Queue
{
    public class Queue_Dequeue : TestQueue
    {
        [Fact]
        public void Enqueue_EmptyQueue_ThrowsInvalidOperationException()
        {
            void action() => _queue.Dequeue();

            Assert.Throws<InvalidOperationException>(action);
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
        public void Enqueue_QueueWithValuesFrom1To10_Returns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }

            var actual = _queue.Dequeue();

            Assert.Equal("1", actual);
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
        public void Enqueue_QueueWithValuesFrom1To10_CountReturnsNewQueueLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            _queue.Dequeue();

            var actual = _queue.Count;

            Assert.Equal(length - 1, actual);
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
        public void Enqueue_ValuesFrom1To10_EnumeratorReturnsNewQueueLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            _queue.Dequeue();

            int actual = 0;
            foreach (var item in _queue)
            {
                actual++;
            }

            Assert.Equal(length - 1, actual);
        }
    }
}
