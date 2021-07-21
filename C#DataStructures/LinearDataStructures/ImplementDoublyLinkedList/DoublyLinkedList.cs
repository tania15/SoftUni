using System;

namespace ImplementDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Last { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        public DoublyLinkedList(T value)
            : this()
        {
            Node<T> firstNode = new Node<T>
            {
                Value = value
            };

            Head = Last = firstNode;
            Count++;
        }

        public DoublyLinkedList(T[] values)
            : this()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Node<T> newNode = new Node<T>
                {
                    Value = values[i]
                    //Previos = Last
                };

                if (Count == 0)
                {
                    Head = newNode;
                }
                else
                {
                    Last.Next = newNode;
                    newNode.Previous = Last;
                }

                //Last.Next = newNode;
                Last = newNode;
                Count++;
            }
        }

        // O(1)
        public void AddFirst(T value)
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
        public void AddLast(T value)
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
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
            }

            Count++;
        }

        // O(n)
        public void Insert(T value, int index)
        {
            ValidateIndex(index);

            int i = 0;
            Node<T> curr = Head;

            while (i < index)
            {
                curr = curr.Next;

                i++;
            }

            if (Count == 0)
            {
                Node<T> newNode = new Node<T>
                {
                    Value = value
                };

                Head = Last = newNode;
            }
            else
            {
                Node<T> newNode = new Node<T>
                {
                    Value = value,
                    Previous = curr.Previous,
                    Next = curr
                };

                if (curr.Previous != null)
                {
                    curr.Previous.Next = newNode;
                }
                else
                {
                    Head = newNode;
                }

                curr.Previous = newNode;
            }

            Count++;
        }

        // O(1)
        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list!");
            }

            T value = Head.Value;
            Node<T> second = Head.Next;

            if (second != null)
            {
                second.Previous = null;
            }
            else
            {
                Last = null;
            }

            Head = second;
            Count--;

            return value;
        }

        // O(1)
        public T RemoveLast()
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

        // O(n)
        public T Remove(int index)
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list!");
            }

            ValidateIndex(index);

            Node<T> curr = Head;
            int i = 0;

            while (i < index)
            {
                curr = curr.Next;
                i++;
            }

            T result = curr.Value;

            if (curr.Previous != null)
            {
                curr.Previous.Next = curr.Next;
            }
            else
            {
                Head = curr.Next;
            }

            if (curr.Next != null)
            {
                curr.Next.Previous = curr.Previous;
            }
            else
            {
                Last = curr.Previous;
            }

            Count--;
            return result;
        }

        // O(n)
        //public int IndexOf(T element)
        //{
        //    if (Count == 0)
        //    {
        //        throw new ArgumentException("List is empty!");
        //    }

        //    Node<T> curr = Head;
        //    int index = 0;

        //    while (curr != null)
        //    {
        //        if (curr.Value == element)
        //        {
        //            return index;
        //        }

        //        index++;
        //        curr = curr.Next;
        //    }

        //    throw new ArgumentException($"The value {element} is not finded!");
        //}

        public void ForEach(Action<T> action)
        {
            Node<T> current = Head;

            while (current != null)
            {
                action(current.Value);

                current = current.Next;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
        }
    }
}
