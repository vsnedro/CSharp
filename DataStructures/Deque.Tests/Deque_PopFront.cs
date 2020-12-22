using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_PopFront : TestDeque
    {
        [Fact]
        public void PopFront_EmptyDeque_ThrowsInvalidOperationException()
        {
            void action() => _deque.PopFront();

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
        public void PopFront_DequeWithValuesFrom1To10_Returns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }

            var actual = _deque.PopFront();

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
        public void PopFront_DequeWithValuesFrom1To10_CountReturnsNewDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PopFront();

            var actual = _deque.Count;

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
        public void PopFront_ValuesFrom1To10_EnumeratorReturnsNewDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PopFront();

            int actual = 0;
            foreach (var item in _deque)
            {
                actual++;
            }

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
        public void PopFront_ValuesFrom1To10_BackEnumeratorReturnsNewDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PopFront();

            int actual = 0;
            foreach (var item in _deque.BackEnumerator())
            {
                actual++;
            }

            Assert.Equal(length - 1, actual);
        }
    }
}
