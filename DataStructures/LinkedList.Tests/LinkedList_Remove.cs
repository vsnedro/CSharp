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
        public void Remove_ListWithValuesFrom1To10_RemoveFirstValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Remove("1");

            Assert.True(result);
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
        public void Remove_ListWithValuesFrom1To10_RemoveLastValueReturnsTrue(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Remove(length.ToString());

            Assert.True(result);
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
        public void Remove_ListWithValuesFrom1To10_RemoveFirstValueCountReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("1");
            var actual = _list.Count;

            Assert.Equal(length - 1, actual);
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
        public void Remove_ListWithValuesFrom1To10_RemoveLastValueCountReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove(length.ToString());
            var actual = _list.Count;

            Assert.Equal(length - 1, actual);
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
        public void Remove_ListWithValuesFrom1To10_RemoveFirstValueEnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove("1");

            int actual = 0;
            foreach (var item in _list)
            {
                actual++;
            }

            Assert.Equal(length - 1, actual);
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
        public void Remove_ListWithValuesFrom1To10_RemoveLastValueEnumeratorReturnsLength(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Remove(length.ToString());

            int actual = 0;
            foreach (var item in _list)
            {
                actual++;
            }

            Assert.Equal(length - 1, actual);
        }
    }
}
