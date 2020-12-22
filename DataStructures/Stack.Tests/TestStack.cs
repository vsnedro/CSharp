using System;
using DataStructures.Stack;

namespace DataStructures.Tests.Stack
{
    public abstract class TestStack
    {
        protected readonly Stack<string> _stack;

        public TestStack()
        {
            _stack = new Stack<string>();
        }
    }
}
