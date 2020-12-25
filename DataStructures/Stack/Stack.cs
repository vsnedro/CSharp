using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Stack
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
    /// Stack
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IEnumerable<T>
    {
        private Node<T> _first = null;
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements contained in the stack.
        /// </summary>
        public int Count { get => _count; }

        /// <summary>
        /// Removes all elements from the stack.
        /// </summary>
        public void Clear()
        {
            _first = null;
            _count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the stack.
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
        /// Returns the element at the top of the stack without removing it.
        /// </summary>
        public T Peek()
        {
            if (_count <= 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return _first.Data;
        }

        /// <summary>
        /// Removes and returns the object at the top of the stack.
        /// </summary>
        public T Pop()
        {
            if (_count <= 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            var result = _first.Data;
            _first = _first.Next;
            _count--;
            return result;
        }

        /// <summary>
        /// Inserts an object at the top of the stack.
        /// </summary>
        public void Push(T item)
        {
            var node = new Node<T>(item)
            {
                Next = _first
            };
            _first = node;
            _count++;
        }

        /// <summary>
        /// Reverses the order of the elements in the entire stack.
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
        /// Copies the stack to a new array.
        /// </summary>
        /// <returns>
        /// A new array containing copies of the elements of the stack.
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
        #endregion
    }
}
