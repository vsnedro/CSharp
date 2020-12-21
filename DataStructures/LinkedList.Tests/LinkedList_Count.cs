using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Count : TestLinkedList
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
