using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Queue
{
    /// <summary>
    /// Node in a singly linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }

    /// <summary>
    /// Queue
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T> : IEnumerable<T>
    {
        private Node<T> _first = null;
        private Node<T> _last = null;
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements contained in the queue.
        /// </summary>
        public int Count { get => _count; }

        /// <summary>
        /// Removes all elements from the queue.
        /// </summary>
        public void Clear()
        {
            _first = null;
            _count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the queue.
        /// </summary>
        public bool Contains(T item)
        {
            var curr = _first;
            while (curr != null)
            {
                if (curr.Data.Equals(item))
                {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        /// <summary>
        /// Removes and returns the element at the beginning of the queue.
        /// </summary>
        public T Dequeue()
        {
            if (_count <= 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            var result = _first.Data;
            _first = _first.Next;
            if (_first == null)
            {
                _last = null;
            }
            _count--;
            return result;
        }

        /// <summary>
        /// Adds an element to the end of the queue.
        /// </summary>
        public void Enqueue(T item)
        {
            var node = new Node<T>(item);
            // empty list
            if (_first == null)
            {
                _first = node;
            }
            // non-empty list
            else
            {
                _last.Next = node;
            }
            _last = node;
            _count++;
        }

        /// <summary>
        /// Returns the element at the beginning of the queue without removing it.
        /// </summary>
        public T Peek()
        {
            if (_count <= 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return _first.Data;
        }

        /// <summary>
        /// Reverses the order of the elements in the entire queue.
        /// </summary>
        public void Reverse()
        {
            Node<T> prev = null, curr = _first, next;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            _first = prev;
        }

        /// <summary>
        /// Copies the queue elements to a new array.
        /// </summary>
        /// <returns>
        /// A new array containing elements copied from the queue.
        /// </returns>
        public T[] ToArray()
        {
            var result = new T[_count];
            var curr = _first;
            var index = 0;
            while (curr != null)
            {
                result[index] = curr.Data;
                index++;
                curr = curr.Next;
            }
            return result;
        }

        #region IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            var curr = _first;
            while (curr != null)
            {
                yield return curr.Data;
                curr = curr.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        #endregion
    }
}
