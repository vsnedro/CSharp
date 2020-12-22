using System;
using Xunit;

namespace DataStructures.Tests.Stack
{
    public class Stack_Peek : TestStack
    {
        [Fact]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            void action() => _stack.Peek();

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
        public void Peek_StackWithValuesFrom1To10_ReturnsLastValue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }

            var actual = _stack.Peek();

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
        public void Peek_StackWithValuesFrom1To10_CountReturnsStackLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            _stack.Peek();

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
        public void Peek_ValuesFrom1To10_EnumeratorReturnsStackLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            _stack.Peek();

            int actual = 0;
            foreach (var item in _stack)
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
