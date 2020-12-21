using System;
using Xunit;

namespace DataStructures.Tests.DoublyLinkedList
{
    public class DoublyLinkedList_First : TestDoublyLinkedList
    {
        [Fact]
        public void First_EmptyList_ReturnsNull()
        {
            var result = _list.First;

            Assert.Null(result);
        }
    }
}
