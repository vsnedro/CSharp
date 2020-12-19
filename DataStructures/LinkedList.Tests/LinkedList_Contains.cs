using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Contains : TestLinkedList
    {
        [Fact]
        public void Contains_EmptyList_ReturnsFalse()
        {
            var result = _list.Contains("");

            Assert.False(result);
        }

        [Fact]
        public void Contains_NonEmptyListWithoutValue_ReturnsFalse()
        {
            _list.Add("");
            var result = _list.Contains("1");

            Assert.False(result);
        }

        [Fact]
        public void Contains_NonEmptyListWithValue_ReturnsTrue()
        {
            _list.Add("1");
            var result = _list.Contains("1");

            Assert.True(result);
        }
    }
}
