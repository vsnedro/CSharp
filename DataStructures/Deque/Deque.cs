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
        private DoublyNode<T> _first = null;
        private DoublyNode<T> _last = null;
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements contained in the deque.
        /// </summary>
        public int Count { get => _count; }

        /// <summary>
        /// Removes all elements from the queue.
        /// </summary>
        public void Clear()
        {
            _first = null;
            _last = null;
            _count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the deque.
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
        /// Removes and returns the element at the end of the deque.
        /// </summary>
        public T PopBack()
        {
            if (_count <= 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }
            var result = _last.Data;
            var prev = _last.Prev;
            _last = prev;
            if (prev != null)
            {
                prev.Next = null;
            }
            if (_last == null)
            {
                _first = null;
            }
            _count--;
            return result;
        }

        /// <summary>
        /// Removes and returns the element at the beginning of the deque.
        /// </summary>
        public T PopFront()
        {
            if (_count <= 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }
            var result = _first.Data;
            var next = _first.Next;
            _first = next;
            if (next != null)
            {
                next.Prev = null;
            }
            if (_first == null)
            {
                _last = null;
            }
            _count--;
            return result;
        }

        /// <summary>
        /// Adds an element to the end of the deque.
        /// </summary>
        public void PushBack(T item)
        {
            var node = new DoublyNode<T>(item);
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
        /// Adds an element to the end of the deque.
        /// </summary>
        public void PushFront(T item)
        {
            var node = new DoublyNode<T>(item);
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
        /// Returns the element at the beginning of the deque without removing it.
        /// </summary>
        public T PeekFront()
        {
            if (_count > 0)
            {
                return _first.Data;
            }
            throw new InvalidOperationException("Deque is empty");
        }

        /// <summary>
        /// Returns the element at the end of the deque without removing it.
        /// </summary>
        public T PeekBack()
        {
            if (_count > 0)
            {
                return _last.Data;
            }
            throw new InvalidOperationException("Deque is empty");
        }

        /// <summary>
        /// Reverses the order of the elements in the entire deque.
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
        /// Copies the deque elements to a new array.
        /// </summary>
        /// <returns>
        /// A new array containing elements copied from the deque.
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