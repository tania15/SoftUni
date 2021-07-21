using System;


namespace ImplementStack
{
    public class Stack<T> 
    {
        public Node<T> Head { get; set; }

        public Node<T> Last { get; set; }
        public int Count { get; set; }

        public Stack()
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        // O(1)
        public void Push(T value)
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

        // O(1)
        public T Pop()
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
