using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Count : TestLinkedList
    {
        [Fact]
        public void Count_EmptyList_Returns0()
        {
            Assert.Equal(0, _list.Count);
        }

        [Fact]
        public void Count_AddItemToEmptyList_Returns1()
        {
            _list.Add("");

            Assert.Equal(1, _list.Count);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        [InlineData(7, 7)]
        [InlineData(8, 8)]
        [InlineData(9, 9)]
        [InlineData(10, 10)]
        public void Count_AddItemsToEmptyList_ReturnsLength(int length, int expected)
        {
            for (int i = 0; i < length; i++)
            {
                _list.Add("");
            }

            Assert.Equal(expected, _list.Count);
        }
    }
}
