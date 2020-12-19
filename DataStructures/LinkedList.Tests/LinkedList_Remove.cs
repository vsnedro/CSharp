using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Remove : TestLinkedList
    {
        [Fact]
        public void Remove_EmptyList_ReturnsFalse()
        {
            var result = _list.Remove("");

            Assert.False(result);
        }

        [Fact]
        public void Remove_NonEmptyListWithoutValue_ReturnsFalse()
        {
            _list.Add("");
            var result = _list.Remove("1");

            Assert.False(result);
        }

        [Fact]
        public void Remove_NonEmptyListWithValue_ReturnsTrue()
        {
            var data = "1";
            _list.Add(data);
            var result = _list.Remove(data);

            Assert.True(result);
        }

        [Fact]
        public void Remove_NonEmptyListWithValue_CountReturns0()
        {
            _list.Add("");
            _list.Remove("");

            Assert.Equal(0, _list.Count);
        }
    }
}
