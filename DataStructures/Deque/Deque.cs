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
        private DoublyNode<T> first = null;
        private DoublyNode<T> last = null;
        private int count = 0;

        /// <summary>
        /// Gets the number of elements contained in the deque.
        /// </summary>
        public int Count { get => count; }

        /// <summary>
        /// Removes all elements from the queue.
        /// </summary>
        public void Clear()
        {
            first = null;
            last = null;
            count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the deque.
        /// </summary>
        public bool Contains(T item)
        {
            var curr = first;
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
            if (count > 0)
            {
                var result = last.Data;
                var prev = last.Prev;
                last = prev;
                if (prev != null)
                {
                    prev.Next = null;
                }
                if (last == null)
                {
                    first = null;
                }
                count--;
                return result;
            }
            throw new InvalidOperationException("Deque is empty");
        }

        /// <summary>
        /// Removes and returns the element at the beginning of the deque.
        /// </summary>
        public T PopFront()
        {
            if (count > 0)
            {
                var result = first.Data;
                var next = first.Next;
                first = next;
                if (next != null)
                {
                    next.Prev = null;
                }
                if (first == null)
                {
                    last = null;
                }
                count--;
                return result;
            }
            throw new InvalidOperationException("Deque is empty");
        }

        /// <summary>
        /// Adds an element to the end of the deque.
        /// </summary>
        public void PushBack(T item)
        {
            var node = new DoublyNode<T>(item);
            // empty list
            if (first == null)
            {
                first = node;
            }
            // non-empty list
            else
            {
                last.Next = node;
                node.Prev = last;
            }
            last = node;
            count++;
        }

        /// <summary>
        /// Adds an element to the end of the deque.
        /// </summary>
        public void PushFront(T item)
        {
            var node = new DoublyNode<T>(item);
            // empty list
            if (first == null)
            {
                last = node;
            }
            // non-empty list
            else
            {
                node.Next = first;
                first.Prev = node;
            }
            first = node;
            count++;
        }

        /// <summary>
        /// Returns the element at the beginning of the deque without removing it.
        /// </summary>
        public T PeekFront()
        {
            if (count > 0)
            {
                return first.Data;
            }
            throw new InvalidOperationException("Deque is empty");
        }

        /// <summary>
        /// Returns the element at the end of the deque without removing it.
        /// </summary>
        public T PeekBack()
        {
            if (count > 0)
            {
                return last.Data;
            }
            throw new InvalidOperationException("Deque is empty");
        }

        /// <summary>
        /// Reverses the order of the elements in the entire deque.
        /// </summary>
        public void Reverse()
        {
            DoublyNode<T> prev = null, curr = first, next;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                curr.Prev = next;
                prev = curr;
                curr = next;
            }
            last = first;
            first = prev;
        }

        /// <summary>
        /// Copies the deque elements to a new array.
        /// </summary>
        /// <returns>
        /// A new array containing elements copied from the deque.
        /// </returns>
        public T[] ToArray()
        {
            T[] result = new T[count];
            var curr = first;
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
            var curr = first;
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
            var curr = last;
            while (curr != null)
            {
                yield return curr.Data;
                curr = curr.Prev;
            }
        }
        #endregion
    }
}