using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Add : TestLinkedList
    {
        [Fact]
        public void Add_SingleValue_ReturnsNode()
        {
            var node = _list.Add("");

            Assert.NotNull(node);
        }

        [Fact]
        public void Add_SingleValue_ReturnesData()
        {
            var expected = "value";
            var node = _list.Add(expected);
            var actual = node?.Data;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_SingleValue_CountReturnes1()
        {
            _list.Add("");

            Assert.Equal(1, _list.Count);
        }

        [Fact]
        public void Add_SingleValue_FirstReturnsNotNull()
        {
            _list.Add("");
            var result = _list.First;

            Assert.NotNull(result);
        }

        [Fact]
        public void Add_SingleValue_FirstReturnsData()
        {
            var data = "1";
            _list.Add(data);
            var result = _list.First;

            Assert.Equal(data, result?.Data);
        }

        [Fact]
        public void Add_SingleValue_LastReturnsNotNull()
        {
            _list.Add("");
            var result = _list.Last;

            Assert.NotNull(result);
        }

        [Fact]
        public void Add_SingleValue_LastReturnsData()
        {
            var data = "1";
            _list.Add(data);
            var result = _list.Last;

            Assert.Equal(data, result?.Data);
        }

        [Fact]
        public void Add_SomeValues_FirstReturnsNotNull()
        {
            var first = 1;
            var length = 10;
            for (int i = first; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.First;

            Assert.NotNull(result);
        }

        [Fact]
        public void Add_SomeValues_FirstReturnsData()
        {
            var first = 1;
            var length = 10;
            for (int i = first; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.First;

            Assert.Equal(first.ToString(), result?.Data);
        }

        [Fact]
        public void Add_SomeValues_LastReturnsNotNull()
        {
            var first = 1;
            var length = 10;
            for (int i = first; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Last;

            Assert.NotNull(result);
        }

        [Fact]
        public void Add_SomeValues_LastReturnsData()
        {
            var first = 1;
            var length = 10;
            for (int i = first; i <= length; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Last;

            Assert.Equal(length.ToString(), result?.Data);
        }
    }
}
