using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_IndexOf : TestLinkedList
    {
        [Fact]
        public void IndexOf_EmptyList_ReturnsMinus1()
        {
            var actual = _list.IndexOf("1");

            Assert.Equal(-1, actual);
        }

        [Fact]
        public void IndexOf_ListWithValue0_IndexOf1ReturnsMinus1()
        {
            _list.Add("0");
            var actual = _list.IndexOf("1");

            Assert.Equal(-1, actual);
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
        public void IndexOf_ListWithValuesFrom1To10_IndexOf1Returns0(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var actual = _list.IndexOf("1");

            Assert.Equal(0, actual);
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
        public void IndexOf_ListWithValuesFrom1To10_IndexOfLastReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var actual = _list.IndexOf(length.ToString());

            Assert.Equal(length - 1, actual);
        }
    }
}
