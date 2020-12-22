using System;
using Xunit;

namespace DataStructures.Tests.Queue
{
    public class Queue_Clear : TestQueue
    {
        [Fact]
        public void Clear_NonEmptyQueue_CountReturns0()
        {
            _queue.Enqueue("");
            _queue.Clear();
            var actual = _queue.Count;

            Assert.Equal(0, actual);
        }
    }
}
