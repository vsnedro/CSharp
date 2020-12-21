using System;
using Xunit;

namespace DataStructures.Tests.DoublyLinkedList
{
    public class DoublyLinkedList_Last : TestDoublyLinkedList
    {
        [Fact]
        public void Last_EmptyList_ReturnsNull()
        {
            var result = _list.Last;

            Assert.Null(result);
        }
    }
}
