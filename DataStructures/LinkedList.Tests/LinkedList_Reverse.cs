using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Reverse : TestLinkedList
    {
        [Fact]
        public void Reverse_EmptyList_CountReturnes0()
        {
            _list.Reverse();
            var actual = _list.Count;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Reverse_EmptyList_FirstReturnesNull()
        {
            _list.Reverse();
            var result = _list.First;

            Assert.Null(result);
        }

        [Fact]
        public void Reverse_EmptyList_LastReturnesNull()
        {
            _list.Reverse();
            var result = _list.Last;

            Assert.Null(result);
        }

        [Fact]
        public void Reverse_ListWithValue1_CountReturnes1()
        {
            _list.Add("1");
            _list.Reverse();
            var actual = _list.Count;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Reverse_ListWithValue1_FirstReturnesNotNull()
        {
            _list.Add("1");
            _list.Reverse();
            var result = _list.First;

            Assert.NotNull(result);
        }

        [Fact]
        public void Reverse_ListWithValue1_FirstReturnesData1()
        {
            _list.Add("1");
            _list.Reverse();
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }

        [Fact]
        public void Reverse_ListWithValue1_LastReturnesNotNull()
        {
            _list.Add("1");
            _list.Reverse();
            var result = _list.Last;

            Assert.NotNull(result);
        }

        [Fact]
        public void Reverse_ListWithValue1_LastReturnesData1()
        {
            _list.Add("1");
            _list.Reverse();
            var result = _list.Last;
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }

        [Fact]
        public void Reverse_ListWithValuesFrom1To10_CountReturnes10()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Reverse();
            var actual = _list.Count;

            Assert.Equal(10, actual);
        }

        [Fact]
        public void Reverse_ListWithValuesFrom1To10_FirstReturnesNotNull()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Reverse();
            var result = _list.First;

            Assert.NotNull(result);
        }

        [Fact]
        public void Reverse_ListWithValuesFrom1To10_FirstReturnesData10()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Reverse();
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("10", actual);
        }

        [Fact]
        public void Reverse_ListWithValuesFrom1To10_LastReturnesNotNull()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Reverse();
            var result = _list.Last;

            Assert.NotNull(result);
        }

        [Fact]
        public void Reverse_ListWithValuesFrom1To10_LastReturnesData1()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Reverse();
            var result = _list.Last;
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }
    }
}
