using System;

namespace ImplementSinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinledList<int> values = new SinglyLinledList<int>(1);
            values.AddFirst(2);
            values.AddFirst(3);
            values.AddFirst(4);
            values.AddFirst(5);
            values.AddFirst(6);
            values.AddLast(0);

            //values.RemoveFirst();
            Console.WriteLine(values.RemoveLast());

            Node<int> next = values.Head;
            Console.WriteLine();

            while (next != null)
            {
                Console.WriteLine(next.Value);

                next = next.Next;
            }            
        }
    }
}
