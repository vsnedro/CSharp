using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Remove : TestLinkedList
    {
        [Fact]
        public void Remove_EmptyList_ReturnsFalse()
        {
            var result = _list.Remove("");

            Assert.False(result);
        }

        [Fact]
        public void Remove_ListWithValue0_Remove1ReturnsFalse()
        {
            _list.Add("0");
            var result = _list.Remove("1");

            Assert.False(result);
        }

        [Fact]
        public void Remove_ListWithValue0_Remove1CountReturns1()
        {
            _list.Add("0");
            _list.Remove("1");
            var actual = _list.Count;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Remove_ListWithValue1_Remove1ReturnsTrue()
        {
            _list.Add("1");
            var result = _list.Remove("1");

            Assert.True(result);
        }

        [Fact]
        public void Remove_ListWithValue1_Remove1CountReturns0()
        {
            _list.Add("1");
            _list.Remove("1");
            var actual = _list.Count;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Remove_ListWithValue1_Remove1FirstReturnsNull()
        {
            _list.Add("1");
            _list.Remove("1");
            var result = _list.First;

            Assert.Null(result);
        }

        [Fact]
        public void Remove_ListWithValue1_Remove1LastReturnsNull()
        {
            _list.Add("1");
            _list.Remove("1");
            var actual = _list.Last;

            Assert.Null(actual);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove1ReturnsTrue()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Remove("1");

            Assert.True(result);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove1CountReturns9()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("1");
            var actual = _list.Count;

            Assert.Equal(9, actual);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove1FirstReturns2()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("1");
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("2", actual);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove1LastReturns10()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("1");
            var result = _list.Last;
            var actual = result?.Data;

            Assert.Equal("10", actual);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove10ReturnsTrue()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Remove("10");

            Assert.True(result);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove10CountReturns9()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("10");
            var actual = _list.Count;

            Assert.Equal(9, actual);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove10FirstReturns1()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("10");
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }

        [Fact]
        public void Remove_ListWithValuesFrom1To10_Remove10LastReturns9()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("10");
            var result = _list.Last;
            var actual = result?.Data;

            Assert.Equal("9", actual);
        }
    }
}
