using System;
using DataStructures.Deque;

namespace DataStructures.Tests.Deque
{
    public abstract class TestDeque
    {
        protected readonly Deque<string> _deque;

        public TestDeque()
        {
            _deque = new Deque<string>();
        }
    }
}
