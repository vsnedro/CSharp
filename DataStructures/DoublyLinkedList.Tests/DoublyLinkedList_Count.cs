using System;
using Xunit;

namespace DataStructures.Tests.DoublyLinkedList
{
    public class DoublyLinkedList_Count : TestDoublyLinkedList
    {
        [Fact]
        public void Count_EmptyList_Returns0()
        {
            var actual = _list.Count;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Count_AddItemToEmptyList_Returns1()
        {
            _list.Add("");
            var actual = _list.Count;

            Assert.Equal(1, actual);
        }
    }
}
