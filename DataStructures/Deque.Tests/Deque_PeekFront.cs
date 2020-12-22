using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_PeekFront : TestDeque
    {
        [Fact]
        public void PeekFront_EmptyDeque_ThrowsInvalidOperationException()
        {
            void action() => _deque.PeekFront();

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
        public void PeekFront_DequeWithValuesFrom1To10_Returns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }

            var actual = _deque.PeekFront();

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
        public void PeekFront_DequeWithValuesFrom1To10_CountReturnsDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PeekFront();

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
        public void PeekFront_ValuesFrom1To10_EnumeratorReturnsDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PeekFront();

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
        public void PeekFront_ValuesFrom1To10_BackEnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PeekFront();

            int actual = 0;
            foreach (var item in _deque.BackEnumerator())
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
