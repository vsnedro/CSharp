using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Deque
{
    /// <summary>
    /// Node in a doubly linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyNode<T>
    {
        public T Data { get; }
        public DoublyNode<T> Prev { get; set; }
        public DoublyNode<T> Next { get; set; }

        public DoublyNode(T data)
        {
            Data = data;
        }
    }

    /// <summary>
    /// Deque
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deque<T> : IEnumerable<T>
    {
        #region IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public IEnumerable<T> GetBackEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
