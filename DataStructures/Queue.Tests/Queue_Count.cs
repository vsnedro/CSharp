using System;
using Xunit;

namespace DataStructures.Tests.Queue
{
    public class Queue_Count : TestQueue
    {
        [Fact]
        public void Count_EmptyQueue_Returns0()
        {
            var actual = _queue.Count;

            Assert.Equal(0, actual);
        }
    }
}
