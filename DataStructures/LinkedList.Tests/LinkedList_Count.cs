using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Count : TestLinkedList
    {
        [Fact]
        public void Count_EmptyList_Returns0()
        {
            var result = _list.Count;

            Assert.Equal(0, result);
        }

        [Fact]
        public void Count_AddItemToEmptyList_Returns1()
        {
            _list.Add("");
            var result = _list.Count;

            Assert.Equal(1, result);
        }
    }
}
