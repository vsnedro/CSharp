using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_PushFront : TestDeque
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
        public void PushFront_ValuesFrom1To10_CountReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushFront(i.ToString());
            }
            var actual = _deque.Count;

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
        public void PushFront_ValuesFrom1To10_EnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushFront(i.ToString());
            }

            int actual = 0;
            foreach (var item in _deque)
            {
                actual++;
            }

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
        public void PushFront_ValuesFrom1To10_BackEnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushFront(i.ToString());
            }

            int actual = 0;
            foreach (var item in _deque.BackEnumerator())
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
