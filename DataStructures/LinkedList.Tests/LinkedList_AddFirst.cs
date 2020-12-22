using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_AddFirst : TestLinkedList
    {
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
        public void AddFirst_ValuesFrom1To10_CountReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.AddFirst(i.ToString());
            }
            var actual = _list.Count;

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
        public void AddFirst_ValuesFrom1To10_FirstReturnsNotNull(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.AddFirst(i.ToString());
            }
            var result = _list.First;

            Assert.NotNull(result);
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
        public void AddFirst_ValuesFrom1To10_FirstReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.AddFirst(i.ToString());
            }
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal(length.ToString(), actual);
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
        public void AddFirst_ValuesFrom1To10_LastReturnsNotNull(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.AddFirst(i.ToString());
            }
            var result = _list.Last;

            Assert.NotNull(result);
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
        public void AddFirst_ValuesFrom1To10_LastReturns1(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.AddFirst(i.ToString());
            }
            var result = _list.Last;
            var actual = result?.Data;

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
        public void AddFirst_ValuesFrom1To10_EnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.AddFirst(i.ToString());
            }

            int actual = 0;
            foreach (var item in _list)
            {
                actual++;
            }

            Assert.Equal(length, actual);
        }
    }
}
