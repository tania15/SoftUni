using System;
using System.Collections.Generic;

namespace ImplementTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(1, new Node<int>(2, new Node<int>(0), new Node<int>(6), new Node<int>(7)), new Node<int>(3), new Node<int>(4, new Node<int>(10)));

            List<int> listBFS = tree.BFS(tree.Root);
            List<int> listDFS = tree.DFS(tree.Root, 0);


            foreach (var l in listDFS)
            {
                Console.WriteLine(l);
            }
        }
    }
}
