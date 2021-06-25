using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplementingLinkedList
{
    public class CustomLinkedList<T>
    {
        public int Count { get; set; }
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public CustomLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public CustomLinkedList(T value)
            : this()
        {
            Node<T> node = new Node<T>
            {
                Value = value,
                Next = null,
                Previous = null
            };

            Count++;
            Head = node;
            Tail = node;
        }

        public CustomLinkedList(IEnumerable<T> list)
            : this(list.First())
        {
            bool isFirst = true;

            foreach (var item in list)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    Node<T> node = new Node<T>()
                    {
                        Value = item,
                        Previous = Tail,
                        Next = null
                    };

                    Tail.Next = node;
                    Tail = node;
                    Count++;
                }
            }
        }

        public void AddFirst(T element)
        {
            Node<T> newFirst = new Node<T>() { Value = element };

            if (Count == 0)
            {
                Head = Tail = newFirst;
            }
            else
            {
                newFirst.Next = Head;
                Head.Previous = newFirst;
                Head = newFirst;
            }

            Count++;
        }

        public void AddLast(T element)
        {
            Node<T> newLast = new Node<T>() { Value = element };

            if (Count == 0)
            {
                Head = Tail = newLast;
            }
            else
            {
                newLast.Previous = Tail;
                Tail.Next = newLast;
                Tail = newLast;
            }

            Count++;
        }

        public T RemoveFist()
        {
            if (Count > 0)
            {
                T result = Head.Value;
                Node<T> second = Head.Next;

                if (second == null)
                {
                    Tail = null;
                }
                else
                {
                    second.Previous = null;
                }

                Head = second;
                Count--;

                return result;
            }

            throw new IndexOutOfRangeException("Empty list");
        }

        public T RemoveLast()
        {
            if (Count > 0)
            {
                T result = Tail.Value;
                Node<T> previous = Tail.Next;

                if (previous == null)
                {
                    Head = null;
                }
                else
                {
                    previous.Next = null;
                }

                Tail = previous;
                Count--;

                return result;
            }

            throw new IndexOutOfRangeException("Empty list");
        }

        public void ForEach(Action<T> action)
        {
            Node<T> current = Head;

            while (current != null)
            {
                action(current.Value);

                current = current.Next;
            }
        }

        public T[] ToArray()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list");
            }

            T[] result = new T[Count];
            int index = 0;
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                result[index] = currentNode.Value;

                index++;
                currentNode = currentNode.Next;
            }

            return result;
        }
    }
}
