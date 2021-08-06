using System;
using System.Collections.Generic;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap<int> heap = new Heap<int>();
            List<int> elements = new List<int> { 15, 6, 9, 5, 25, 8, 17, 16 };

            foreach (var element in elements)
            {
                heap.Add(element);
            }

            Console.WriteLine(heap.DFS(0, 0));
        }
    }
}
