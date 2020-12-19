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

        [Fact]
        public void First_NonEmptyList_ReturnsNotNull()
        {
            _list.Add("");
            var result = _list.First;

            Assert.NotNull(result);
        }

        [Fact]
        public void First_NonEmptyList_ReturnsData()
        {
            var data = "1";
            _list.Add(data);
            var result = _list.First;

            Assert.Equal(data, result?.Data);
        }
    }
}
