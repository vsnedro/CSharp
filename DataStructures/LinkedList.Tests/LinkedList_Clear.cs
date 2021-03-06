﻿using System;
using Xunit;

namespace DataStructures.Tests.LinkedList
{
    public class LinkedList_Clear : TestLinkedList
    {
        [Fact]
        public void Clear_NonEmptyList_CountReturns0()
        {
            _list.Add("");
            _list.Clear();
            var actual = _list.Count;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Clear_NonEmptyList_FirstReturnsNull()
        {
            _list.Add("");
            _list.Clear();

            var result = _list.First;

            Assert.Null(result);
        }

        [Fact]
        public void Clear_NonEmptyList_LastReturnsNull()
        {
            _list.Add("");
            _list.Clear();

            var result = _list.Last;

            Assert.Null(result);
        }
    }
}
