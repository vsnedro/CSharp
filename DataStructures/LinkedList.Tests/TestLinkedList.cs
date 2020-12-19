using System;
using DataStructures.LinkedList;

namespace DataStructures.Tests.LinkedList
{
    public abstract class TestLinkedList
    {
        protected readonly LinkedList<string> _list;

        public TestLinkedList()
        {
            _list = new LinkedList<string>();
        }
    }
}
