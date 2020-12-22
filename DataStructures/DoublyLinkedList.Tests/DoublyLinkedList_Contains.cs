using System;
using Xunit;

namespace DataStructures.Tests.DoublyLinkedList
{
    public class DoublyLinkedList_Contains : TestDoublyLinkedList
    {
        [Fact]
        public void Contains_EmptyList_ReturnsFalse()
        {
            var actual = _list.Contains("1");

            Assert.False(actual);
        }

        [Fact]
        public void Contains_ListWithValue0_1ReturnsFalse()
        {
            _list.Add("0");
            var actual = _list.Contains("1");

            Assert.False(actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void Contains_ListWithValuesFrom1To10_AddFirstValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.AddFirst(i.ToString());
            }
            var actual = _list.Contains(length.ToString());

            Assert.True(actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void Contains_ListWithValuesFrom1To10_AddValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var actual = _list.Contains(length.ToString());

            Assert.True(actual);
        }
    }
}
