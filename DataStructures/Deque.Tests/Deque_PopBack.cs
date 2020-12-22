using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_PopBack : TestDeque
    {
        [Fact]
        public void PopBack_EmptyDeque_ThrowsInvalidOperationException()
        {
            void action() => _deque.PopBack();

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
        public void PopBack_DequeWithValuesFrom1To10_ReturnsLastValue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }

            var actual = _deque.PopBack();

            Assert.Equal(length.ToString(), actual);
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
        public void PopBack_DequeWithValuesFrom1To10_CountReturnsNewDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PopBack();

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
        public void PopBack_ValuesFrom1To10_EnumeratorReturnsNewDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PopBack();

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
        public void PopBack_ValuesFrom1To10_BackEnumeratorReturnsNewDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.PopBack();

            int actual = 0;
            foreach (var item in _deque.BackEnumerator())
            {
                actual++;
            }

            Assert.Equal(length - 1, actual);
        }
    }
}
