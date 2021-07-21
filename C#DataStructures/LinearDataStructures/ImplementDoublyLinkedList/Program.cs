using System;

namespace ImplementDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            DoublyLinkedList<int> myList = new DoublyLinkedList<int>(arr);

            myList.ForEach(e => Console.WriteLine(e));            
            Console.WriteLine(myList.Count);
            Console.WriteLine();

            //myList.Insert(10, 6);
            //myList.RemoveFirst();
            //myList.RemoveLast();
            myList.Remove(6);

            myList.ForEach(e => Console.WriteLine(e));
            Console.WriteLine();
            Console.WriteLine(myList.Count);

        }
    }
}
