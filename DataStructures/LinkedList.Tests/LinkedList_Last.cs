using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Last : TestLinkedList
    {
        [Fact]
        public void Last_EmptyList_ReturnsNull()
        {
            var result = _list.Last;

            Assert.Null(result);
        }
    }
}
