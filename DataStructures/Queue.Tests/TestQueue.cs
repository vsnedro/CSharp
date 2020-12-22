using System;
using DataStructures.Queue;

namespace DataStructures.Tests.Queue
{
    public abstract class TestQueue
    {
        protected readonly Queue<string> _queue;

        public TestQueue()
        {
            _queue = new Queue<string>();
        }
    }
}
