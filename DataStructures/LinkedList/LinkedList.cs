using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList
{
    /// <summary>
    /// Node in a linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; }
        public Node<T> Next { get; set;  }

        public Node(T data)
        {
            Data = data;
        }
    }

    /// <summary>
    /// Linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> first = null;
        private Node<T> last = null;
        private int count = 0;

        /// <summary>
        /// Add an item to the end of the list
        /// </summary>
        public Node<T> Add(T data)
        {
            var node = new Node<T>(data);

            // empty list
            if (first == null)
            {
                first = node;
            }
            // non-empty list
            else
            {
                last.Next = node;
            }
            last = node;
            count++;
            return node;
        }

        /// <summary>
        /// Add an item at specified index
        /// </summary>
        public Node<T> Insert(int index, T data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove item from list
        /// </summary>
        public Node<T> Remove(T data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the first item in the list
        /// </summary>
        public Node<T> First()
        {
            return first;
        }

        /// <summary>
        /// Get the last item in the list
        /// </summary>
        public Node<T> Last()
        {
            return last;
        }

        /// <summary>
        /// Check if an item is in the list
        /// </summary>
        public bool Contains(T data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Number of items in the list
        /// </summary>
        public int Count()
        {
            return count;
        }

        /// <summary>
        /// Clear list
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }

        #region IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
