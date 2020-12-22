using System;
using Xunit;

namespace DataStructures.Tests.Stack
{
    public class Stack_Count : TestStack
    {
        [Fact]
        public void Count_EmptyStack_Returns0()
        {
            var actual = _stack.Count;

            Assert.Equal(0, actual);
        }
    }
}
