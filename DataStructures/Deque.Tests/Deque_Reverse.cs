using System;
using Xunit;

namespace DataStructures.Tests.Deque
{
    public class Deque_Reverse : TestDeque
    {
        [Fact]
        public void Reverse_EmptyDeque_CountReturns0()
        {
            _deque.Reverse();
            var actual = _deque.Count;

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
        public void Reverse_DequeWithValuesFrom1To10_CountReturnsDequeLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.Reverse();

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
        public void Reverse_DequeWithValuesFrom1To10_PeekBackReturns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.Reverse();

            var actual = _deque.PeekBack();

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
        public void Reverse_DequeWithValuesFrom1To10_PeekFrontReturnsLastValue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.Reverse();

            var actual = _deque.PeekFront();

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
        public void Reverse_DequeWithValuesFrom1To10_EnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.Reverse();

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
        public void Reverse_DequeWithValuesFrom1To10_BackEnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _deque.PushBack(i.ToString());
            }
            _deque.Reverse();

            int actual = 0;
            foreach (var item in _deque.BackEnumerator())
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
