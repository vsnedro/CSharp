using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.DoublyLinkedList
{
    /// <summary>
    /// Node in a doubly linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; }
        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
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
        private Node<T> first = null;
        private Node<T> last = null;
        private int count = 0;

        /// <summary>
        /// Gets the number of elements contained in the list.
        /// </summary>
        public int Count { get => count; }
        /// <summary>
        /// Gets the first element in the list.
        /// </summary>
        public Node<T> First { get => first; }
        /// <summary>
        /// Gets the last element in the list.
        /// </summary>
        public Node<T> Last { get => last; }

        /// <summary>
        /// Adds an element to the end of the list.
        /// </summary>
        public void Add(T data)
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
                node.Prev = last;
            }
            last = node;
            count++;
        }

        /// <summary>
        /// Adds an element to the beginning of the list.
        /// </summary>
        public void AddFirst(T data)
        {
            var node = new Node<T>(data);

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
        /// Removes all elements from the list.
        /// </summary>
        public void Clear()
        {
            first = null;
            last  = null;
            count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the list.
        /// </summary>
        public bool Contains(T data)
        {
            var curr = first;

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
            Node<T> prev = null, curr = first, next;

            while (curr != null)
            {
                next = curr.Next;
                if (curr.Data.Equals(data))
                {
                    if (curr == first)
                    {
                        first = next;
                    }
                    else
                    {
                        prev.Next = next;
                    }
                    if (curr == last)
                    {
                        last = prev;
                    }
                    if (next != null)
                    {
                        next.Prev = prev;
                    }
                    count--;
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
            Node<T> prev = null, curr = first, next;

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
        /// Copies the elements of the list to a new array.
        /// </summary>
        /// <returns>
        /// An array containing copies of the elements of the list.
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

        #region IEnumerator<T>
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
