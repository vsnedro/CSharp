using System;
using DataStructures.DoublyLinkedList;

namespace DataStructures.Tests.DoublyLinkedList
{
    public abstract class TestDoublyLinkedList
    {
        protected readonly DoublyLinkedList<string> _list;

        public TestDoublyLinkedList()
        {
            _list = new DoublyLinkedList<string>();
        }
    }
}
