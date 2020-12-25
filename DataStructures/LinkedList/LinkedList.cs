using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList
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
    /// Singly linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> _first = null;
        private Node<T> _last  = null;
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements contained in the list.
        /// </summary>
        public int Count { get => _count; }
        /// <summary>
        /// Gets the first element in the list.
        /// </summary>
        public Node<T> First { get => _first; }
        /// <summary>
        /// Gets the last element in the list.
        /// </summary>
        public Node<T> Last { get => _last; }

        /// <summary>
        /// Adds an element to the end of the list.
        /// </summary>
        public void Add(T data)
        {
            var node = new Node<T>(data);

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
        /// Adds an element to the beginning of the list.
        /// </summary>
        public void AddFirst(T data)
        {
            var node = new Node<T>(data);

            // empty list
            if (_first == null)
            {
                _last = node;
            }
            // non-empty list
            else
            {
                node.Next = _first;
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
        /// Searches for the specified object and returns the zero-based index of the first occurrence within the entire list.
        /// </summary>
        /// <returns>
        /// The zero-based index of the first occurrence of item within the entire list, if found; otherwise, -1.
        /// </returns>  
        public int IndexOf(T data)
        {
            var curr  = _first;
            var index = 0;

            while (curr != null)
            {
                if (curr.Data.Equals(data))
                {
                    return index;
                }
                curr = curr.Next;
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Inserts an element into the list at the specified index.
        /// </summary>
        public void Insert(int index, T data)
        {
            if (index == 0)
            {
                var node = new Node<T>(data)
                {
                    Next = _first
                };
                _first = node;
                _last ??= node;  // if list was empty
                _count++;
            }
            else
            if (index == _count)
            {
                Add(data);
            }
            else
            if (index > 0 && index < _count)
            {
                var prev = _first;
                for (int i = 0; i < index - 1; i++)
                {
                    prev = prev.Next;
                }
                var node = new Node<T>(data)
                {
                    Next = prev.Next
                };
                prev.Next = node;
                _count++;
            }
            else 
            {
                throw new IndexOutOfRangeException();
            }
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
            Node<T> prev = null, curr = _first;

            while (curr != null)
            {
                if (curr.Data.Equals(data))
                {
                    if (curr == _first)
                    {
                        _first = curr.Next;
                    }
                    else
                    {
                        prev.Next = curr.Next;
                    }
                    if (curr == _last)
                    {
                        _last = prev;
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
            Node<T> prev = null, curr = _first, next;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            _last  = _first;
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

        #region IEnumerable<T>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
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
