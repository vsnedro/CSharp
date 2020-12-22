using System;
using Xunit;

namespace DataStructures.Tests.Stack
{
    public class Stack_Contains : TestStack
    {
        [Fact]
        public void Contains_EmptyStack_ReturnsFalse()
        {
            var actual = _stack.Contains("1");

            Assert.False(actual);
        }

        [Fact]
        public void Contains_StackWithValue0_1ReturnsFalse()
        {
            _stack.Push("0");
            var actual = _stack.Contains("1");

            Assert.False(actual);
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
        public void Contains_StackWithValuesFrom1To10_AddedValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            var actual = _stack.Contains(length.ToString());

            Assert.True(actual);
        }
    }
}
