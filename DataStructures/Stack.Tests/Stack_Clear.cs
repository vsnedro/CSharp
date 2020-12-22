using System;
using Xunit;

namespace DataStructures.Tests.Stack
{
    public class Stack_Clear : TestStack
    {
        [Fact]
        public void Clear_NonEmptyStack_CountReturns0()
        {
            _stack.Push("");
            _stack.Clear();
            var actual = _stack.Count;

            Assert.Equal(0, actual);
        }
    }
}
