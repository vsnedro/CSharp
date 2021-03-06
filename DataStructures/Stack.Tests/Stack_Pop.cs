﻿using System;
using Xunit;

namespace DataStructures.Tests.Stack
{
    public class Stack_Pop : TestStack
    {
        [Fact]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            void action() => _stack.Pop();

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
        public void Pop_StackWithValuesFrom1To10_ReturnsLastValue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }

            var actual = _stack.Pop();

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
        public void Pop_StackWithValuesFrom1To10_CountReturnsNewStackLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            _stack.Pop();

            var actual = _stack.Count;

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
        public void Pop_ValuesFrom1To10_EnumeratorReturnsNewStackLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _stack.Push(i.ToString());
            }
            _stack.Pop();

            int actual = 0;
            foreach (var item in _stack)
            {
                actual++;
            }

            Assert.Equal(length - 1, actual);
        }
    }
}
