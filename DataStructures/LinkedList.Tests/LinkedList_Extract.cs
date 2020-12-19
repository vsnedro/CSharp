using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Extract : TestLinkedList
    {
        [Fact]
        public void Extract_EmptyList_ReturnsNull()
        {
            var result = _list.Extract("");

            Assert.Null(result);
        }

        [Fact]
        public void Extract_ListWithValue0_Extract1ReturnsNull()
        {
            _list.Add("0");
            var result = _list.Extract("1");

            Assert.Null(result);
        }

        [Fact]
        public void Extract_ListWithValue0_Extract1CountReturns1()
        {
            _list.Add("0");
            _list.Extract("1");
            var actual = _list.Count;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Extract_ListWithValue1_Extract1ReturnsNotNull()
        {
            _list.Add("1");
            var result = _list.Extract("1");

            Assert.NotNull(result);
        }

        [Fact]
        public void Extract_ListWithValue1_Extract1ReturnsData1()
        {
            _list.Add("1");
            var result = _list.Extract("1");
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }

        [Fact]
        public void Extract_ListWithValue1_Extract1CountReturns0()
        {
            _list.Add("1");
            _list.Extract("1");
            var actual = _list.Count;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Extract_ListWithValue1_Extract1FirstReturnsNull()
        {
            _list.Add("1");
            _list.Extract("1");
            var result = _list.First;

            Assert.Null(result);
        }

        [Fact]
        public void Extract_ListWithValue1_Extract1LastReturnsNull()
        {
            _list.Add("1");
            _list.Extract("1");
            var result = _list.Last;

            Assert.Null(result);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract1Returns1()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result =_list.Extract("1");
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract1CountReturns9()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Extract("1");
            var actual = _list.Count;

            Assert.Equal(9, actual);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract1FirstReturns2()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Extract("1");
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("2", actual);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract1LastReturns10()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Extract("1");
            var result = _list.Last;
            var actual = result?.Data;

            Assert.Equal("10", actual);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract10Returns10()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            var result = _list.Extract("10");
            var actual = result?.Data;

            Assert.Equal("10", actual);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract10CountReturns9()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Extract("10");
            var actual = _list.Count;

            Assert.Equal(9, actual);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract10FirstReturns1()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Extract("10");
            var result = _list.First;
            var actual = result?.Data;

            Assert.Equal("1", actual);
        }

        [Fact]
        public void Extract_ListWithValuesFrom1To10_Extract10LastReturns9()
        {
            for (int i = 1; i <= 10; i++)
            {
                _list.Add(i.ToString());
            }
            _list.Extract("10");
            var result = _list.Last;
            var actual = result?.Data;

            Assert.Equal("9", actual);
        }
    }
}
