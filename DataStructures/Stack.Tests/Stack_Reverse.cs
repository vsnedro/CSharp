using System;
using Xunit;

namespace DataStructures.Tests.Stack
{
    public class Stack_Reverse : TestStack
    {
        [Fact]
        public void Reverse_EmptyStack_CountReturns0()
        {
            _stack.Reverse();
            var actual = _stack.Count;

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
        public void Reverse_StackWithValuesFrom1To10_CountReturnsStackLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            _stack.Reverse();

            var actual = _stack.Count;

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
        public void Reverse_StackWithValuesFrom1To10_PeekReturns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            _stack.Reverse();

            var actual = _stack.Peek();

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
        public void Reverse_StackWithValuesFrom1To10_EnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            _stack.Reverse();

            int actual = 0;
            foreach (var item in _stack)
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
