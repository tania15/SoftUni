using ImplementingLinkedList;
using System;
using System.Linq;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            CustomLinkedList<int> list = new CustomLinkedList<int>(array);
            list.ForEach(l => Console.WriteLine(l));

            list.AddFirst(8);
            int lastValue = list.RemoveLast();
            int[] numbers = list.ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
