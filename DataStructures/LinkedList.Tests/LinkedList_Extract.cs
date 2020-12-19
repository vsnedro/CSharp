using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Extract : TestLinkedList
    {
        [Fact]
        public void Extract_EmptyList_ReturnsNull()
        {
            var result = _list.Extract("");

            Assert.Null(result);
        }

        [Fact]
        public void Extract_NonEmptyListWithoutValue_ReturnsNull()
        {
            _list.Add("");
            var result = _list.Extract("1");

            Assert.Null(result);
        }

        [Fact]
        public void Extract_NonEmptyListWithValue_ReturnsNotNull()
        {
            var data = "1";
            _list.Add(data);
            var result = _list.Extract(data);

            Assert.NotNull(result);
        }

        [Fact]
        public void Extract_NonEmptyListWithValue_ReturnsData()
        {
            var data = "1";
            _list.Add(data);
            var result = _list.Extract(data);

            Assert.Equal(data, result?.Data);
        }

        [Fact]
        public void Extract_NonEmptyListWithValue_CountReturns0()
        {
            _list.Add("");
            _list.Extract("");

            Assert.Equal(0, _list.Count);
        }
    }
}
