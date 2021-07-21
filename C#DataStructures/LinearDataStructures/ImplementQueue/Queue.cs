using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementQueue
{
    public class Queue<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Last { get; set; }
        public int Count { get; set; }

        public Queue()
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        // O(1)
        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>
            {
                Value = value
            };

            if (Count == 0)
            {
                Head = Last = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }

            Count++;
        }

        // O(1)
        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list!");
            }

            T value = Last.Value;
            Node<T> temp = Last.Previous;

            if (temp != null)
            {
                temp.Next = null;
            }
            else
            {
                Head = null;
            }

            Last = temp;
            Count--;

            return value;
        }

        public T Peek()
        {
            return Last.Value;
        }
    }
}
