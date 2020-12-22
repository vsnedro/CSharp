using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_Count : TestDeque
    {
        [Fact]
        public void Count_EmptyDeque_Returns0()
        {
            var actual = _deque.Count;

            Assert.Equal(0, actual);
        }
    }
}
