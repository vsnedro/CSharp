using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Insert : TestLinkedList
    {
        [Fact]
        public void Insert_Value1_CountReturns1()
        {
            _list.Insert(0, "1");
            var actual = _list.Count;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Insert_Value1_FirstReturnsNotNull()
        {
            _list.Insert(0, "1");
            var result = _list.First;

            Assert.NotNull(result);
        }

        [Fact]
        public void Insert_Value1_FirstReturnsData1()
        {
            _list.Insert(0, "1");
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }

        [Fact]
        public void Insert_Value1_LastReturnsNotNull()
        {
            _list.Insert(0, "1");
            var result = _list.Last;

            Assert.NotNull(result);
        }

        [Fact]
        public void Insert_Value1_LastReturnsData1()
        {
            _list.Insert(0, "1");
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
        public void Insert_ListWithValuesFrom1To10_InsertAtTheBeginningCountReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Insert(0, "0");
            var actual = _list.Count;

            Assert.Equal(length + 1, actual);
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
        public void Insert_ListWithValuesFrom1To10_InsertAtTheBeginningFirstReturnsNotNull(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Insert(0, "0");
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
        public void Insert_ListWithValuesFrom1To10_InsertAtTheBeginningFirstReturnsData0(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Insert(0, "0");
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("0", actual);
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
        public void Insert_ListWithValuesFrom1To10_InsertAtTheEndCountReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Insert(length, "0");
            var actual = _list.Count;

            Assert.Equal(length + 1, actual);
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
        public void Insert_ListWithValuesFrom1To10_InsertAtTheEndLastReturnsNotNull(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Insert(length, "0");
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
        public void Insert_ListWithValuesFrom1To10_InsertAtTheEndLastReturnsData(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Insert(length, "0");
            var result = _list.Last;
            var actual = result?.Data;

            Assert.Equal("0", actual);
        }
    }
}
