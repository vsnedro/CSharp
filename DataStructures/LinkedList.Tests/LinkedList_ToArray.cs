using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_ToArray : TestLinkedList
    {
        [Fact]
        public void ToArray_EmptyList_LengthReturns0()
        {
            var array = _list.ToArray();
            var actual = array.Length;

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
        public void ToArray_ListWithValuesFrom1To10_LengthReturnsActualLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var array = _list.ToArray();
            var actual = array.Length;

            Assert.Equal(length, actual);
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
        public void ToArray_ListWithValuesFrom1To10_FirstItemReturns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var array = _list.ToArray();
            var actual = array[0];

            Assert.Equal("1", actual);
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
        public void ToArray_ListWithValuesFrom1To10_LastItemReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var array = _list.ToArray();
            var actual = array[length - 1];

            Assert.Equal(length.ToString(), actual);
        }
    }
}
