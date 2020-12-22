using System;
using Xunit;

namespace DataStructures.Tests.Stack
{
    public class Stack_ToArray : TestStack
    {
        [Fact]
        public void ToArray_EmptyStack_LengthReturns0()
        {
            var array = _stack.ToArray();
            var actual = array.Length;

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
        public void ToArray_StackWithValuesFrom1To10_LengthReturnsStackLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            var array = _stack.ToArray();
            var actual = array.Length;

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
        public void ToArray_StackWithValuesFrom1To10_FirstItemLastValue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            var array = _stack.ToArray();
            var actual = array[0];

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
        public void ToArray_StackWithValuesFrom1To10_LastItemReturns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            var array = _stack.ToArray();
            var actual = array[length - 1];

            Assert.Equal("1", actual);
        }
    }
}
