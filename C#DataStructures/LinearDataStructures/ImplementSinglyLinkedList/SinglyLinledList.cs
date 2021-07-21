using System;

namespace ImplementSinglyLinkedList
{
    public class SinglyLinledList<T>
    {
        public Node<T> Head { get; set; }

        public int Count { get; set; }

        public SinglyLinledList()
        {
            Count = 0;
            Head = null;
        }

        public SinglyLinledList(T value)
            : this()
        {
            Node<T> newNode = new Node<T>
            {
                Value = value,
                Next = null
            };

            Head = newNode;
            Count++;
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
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            Count++;
        }

        // O(N)
        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>
            {
                Value = value
            };

            if (Count == 0)
            {
                Head = newNode;
            }
            else
            {
                //int c = 1;
                //Node<T> last = Head;

                //while (c != Count)
                //{
                //    last = last.Next;
                //    c++;
                //}

                //last.Next = newNode;  
                
                Node<T> last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = newNode;
            }

            Count++;
        }

        // O(1)
        public T RemoveFirst()
        {
            if (Count > 0)
            {
                T value = Head.Value;
                Node<T> newFirst = Head.Next;

                if (newFirst != null)
                {
                    Head.Next = null;
                }

                Head = newFirst;
                Count--;
                return value;
            }

            throw new IndexOutOfRangeException("Empty list");
        }

        // O(N)
        public T RemoveLast()
        {
            if (Count > 0)
            {
                int c = 1;
                Node<T> last = Head;

                while (c != Count - 1)
                {
                    last = last.Next;
                    c++;
                }

                T value = last.Next.Value;
                last.Next = null;
                Count--;

                return value;
            }

            throw new IndexOutOfRangeException("Empty list");
        }

        // O(N)
        //public bool Contain(T value)
        //{
        //    Node<T> next = Head;

        //    while (Head != null)
        //    {
        //        if (next.Value == value)
        //        {
        //            return true;
        //        }

        //        next = next.Next;
        //    }

        //    return false;
        //}


    }
}
