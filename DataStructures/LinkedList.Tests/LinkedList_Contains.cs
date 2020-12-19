using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Contains : TestLinkedList
    {
        [Fact]
        public void Contains_EmptyList_ReturnsFalse()
        {
            var result = _list.Contains("1");

            Assert.False(result);
        }

        [Fact]
        public void Contains_ListWithValue0_Contains1ReturnsFalse()
        {
            _list.Add("0");
            var result = _list.Contains("1");

            Assert.False(result);
        }

        [Fact]
        public void Contains_ListWithValue1_Contains1ReturnsTrue()
        {
            _list.Add("1");
            var result = _list.Contains("1");

            Assert.True(result);
        }

        [Fact]
        public void Contains_ListWithValuesFrom1To10_Contains1ReturnsTrue()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Contains("1");

            Assert.True(result);
        }

        [Fact]
        public void Contains_ListWithValuesFrom1To10_Contains10ReturnsTrue()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Contains("10");

            Assert.True(result);
        }
    }
}
