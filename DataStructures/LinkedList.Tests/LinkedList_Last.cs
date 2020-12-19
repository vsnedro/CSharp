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

        [Fact]
        public void Last_NonEmptyList_ReturnsNotNull()
        {
            _list.Add("");
            var result = _list.Last;

            Assert.NotNull(result);
        }

        [Fact]
        public void Last_NonEmptyList_ReturnsData()
        {
            var data = "1";
            _list.Add(data);
            var result = _list.Last;

            Assert.Equal(data, result?.Data);
        }
    }
}
