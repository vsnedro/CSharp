using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_IndexOf : TestLinkedList
    {
        [Fact]
        public void IndexOf_EmptyList_ReturnsMinus1()
        {
            var result = _list.IndexOf("1");

            Assert.Equal(-1, result);
        }

        [Fact]
        public void IndexOf_ListWithValue0_IndexOf1ReturnsMinus1()
        {
            _list.Add("0");
            var result = _list.IndexOf("1");

            Assert.Equal(-1, result);
        }

        [Fact]
        public void IndexOf_ListWithValue1_IndexOf1Returns0()
        {
            _list.Add("1");
            var result = _list.IndexOf("1");

            Assert.Equal(0, result);
        }

        [Fact]
        public void IndexOf_ListWithValuesFrom1To10_IndexOf1Returns0()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.IndexOf("1");

            Assert.Equal(0, result);
        }

        [Fact]
        public void IndexOf_ListWithValuesFrom1To10_IndexOf10Returns9()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.IndexOf("10");

            Assert.Equal(9, result);
        }
    }
}
