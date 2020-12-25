using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.DoublyLinkedList
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
    /// Doubly linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private DoublyNode<T> _first = null;
        private DoublyNode<T> _last = null;
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements contained in the list.
        /// </summary>
        public int Count { get => _count; }
        /// <summary>
        /// Gets the first element in the list.
        /// </summary>
        public DoublyNode<T> First { get => _first; }
        /// <summary>
        /// Gets the last element in the list.
        /// </summary>
        public DoublyNode<T> Last { get => _last; }

        /// <summary>
        /// Adds an element to the end of the list.
        /// </summary>
        public void Add(T data)
        {
            var node = new DoublyNode<T>(data);

            // empty list
            if (_first == null)
            {
                _first = node;
            }
            // non-empty list
            else
            {
                _last.Next = node;
                node.Prev = _last;
            }
            _last = node;
            _count++;
        }

        /// <summary>
        /// Adds an element to the beginning of the list.
        /// </summary>
        public void AddFirst(T data)
        {
            var node = new DoublyNode<T>(data);

            // empty list
            if (_first == null)
            {
                _last = node;
            }
            // non-empty list
            else
            {
                node.Next = _first;
                _first.Prev = node;
            }
            _first = node;
            _count++;
        }

        /// <summary>
        /// Removes all elements from the list.
        /// </summary>
        public void Clear()
        {
            _first = null;
            _last  = null;
            _count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the list.
        /// </summary>
        public bool Contains(T data)
        {
            var curr = _first;

            while (curr != null)
            {
                if (curr.Data.Equals(data))
                {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        /// <summary>
        /// Removes the first occurrence of a specific element from the list.
        /// </summary>
        /// <returns>
        /// true if item is successfully removed; otherwise, false.
        /// This method also returns false if item was not found in the list.
        /// </returns>
        public bool Remove(T data)
        {
            DoublyNode<T> prev = null, curr = _first, next;

            while (curr != null)
            {
                next = curr.Next;
                if (curr.Data.Equals(data))
                {
                    if (curr == _first)
                    {
                        _first = next;
                    }
                    else
                    {
                        prev.Next = next;
                    }
                    if (curr == _last)
                    {
                        _last = prev;
                    }
                    if (next != null)
                    {
                        next.Prev = prev;
                    }
                    _count--;
                    return true;
                }
                prev = curr;
                curr = curr.Next;
            }
            return false;
        }

        /// <summary>
        /// Reverses the order of the elements in the entire list.
        /// </summary>
        public void Reverse()
        {
            DoublyNode<T> prev = null, curr = _first, next;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                curr.Prev = next;
                prev = curr;
                curr = next;
            }
            _last = _first;
            _first = prev;
        }

        /// <summary>
        /// Copies the elements of the list to a new array.
        /// </summary>
        /// <returns>
        /// An array containing copies of the elements of the list.
        /// </returns>
        public T[] ToArray()
        {
            T[] result = new T[_count];
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

        #region IEnumerator<T>
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

        public IEnumerable<T> BackEnumerator()
        {
            var curr = _last;
            while (curr != null)
            {
                yield return curr.Data;
                curr = curr.Prev;
            }
        }
        #endregion
    }
}
