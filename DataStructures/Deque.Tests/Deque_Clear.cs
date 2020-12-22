using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_Clear : TestDeque
    {
        [Fact]
        public void Clear_NonEmptyDeque_CountReturns0()
        {
            _deque.PushBack("");
            _deque.Clear();
            var actual = _deque.Count;

            Assert.Equal(0, actual);
        }
    }
}
