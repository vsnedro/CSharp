using System;
using Xunit;

namespace DataStructures.Tests.Queue
{
    public class Queue_ToArray : TestQueue
    {
        [Fact]
        public void ToArray_EmptyQueue_LengthReturns0()
        {
            var array = _queue.ToArray();
            var actual = array.Length;

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
        public void ToArray_QueueWithValuesFrom1To10_LengthReturnsQueueLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            var array = _queue.ToArray();
            var actual = array.Length;

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
        public void ToArray_QueueWithValuesFrom1To10_FirstItem1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            var array = _queue.ToArray();
            var actual = array[0];

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
        public void ToArray_QueueWithValuesFrom1To10_LastItemReturnsLastValue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _queue.Enqueue(i.ToString());
            }
            var array = _queue.ToArray();
            var actual = array[length - 1];

            Assert.Equal(length.ToString(), actual);
        }
    }
}
