using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_First : TestLinkedList
    {
        [Fact]
        public void First_EmptyList_ReturnsNull()
        {
            var result = _list.First;

            Assert.Null(result);
        }
    }
}
